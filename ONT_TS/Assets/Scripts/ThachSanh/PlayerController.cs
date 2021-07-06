using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Animations.Rigging;
using Cinemachine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader = default;
    [Header("Sub behaviours")]
    public PlayerAnimationBehaviour playerAnimationBehaviour;
    public PlayerMovementBehaviour playerMovementBehaviour;

    [Header("Input Setting")]
    private bool sprintPressed = false;
    public CinemachineFreeLook gameCam;
    public CinemachineVirtualCamera aimCam;
    public Rig aimRig;
    public Transform aimTarget;
    Vector2 cameraInput;
    public bool m_isAiming;

    [Header("Movements")]
    public float velocity = 0f;
    [SerializeField] float acceleration = 0.1f;
    [SerializeField] float decceleration = 1f;
    [SerializeField] float slideDecceleration = 1f;
    [SerializeField] float normalRunSpeed = 7f;
    [SerializeField] float sprintSpeed = 10f;
    [SerializeField] float crouchSpeed = 3f;
    [SerializeField] float slideTime = 1f;
    private float slideCountDown = 0f;
    private Vector3 rawInputMovement;
    private bool isGrounded = true;
    private bool isCrouching = false;
    private bool isMoving = false;

    //Attack setting
    private bool attackInput = false;
    protected bool m_InAttack;


    [Header("Hit Point")]
    public Transform hitPoint;
    public float attackRange = 2f;
    public LayerMask enemyLayers;
    private void OnEnable()
    {
        _inputReader.moveEvent += OnMove;
        _inputReader.startRunning += OnStartRunning;
        _inputReader.stopRunning += OnStopRunning;
        _inputReader.jumpEvent += OnJumpTrigger;
        _inputReader.crouchEvent += OnCrouching;
        _inputReader.crouchStopEvent += StopCrouching;
        _inputReader.attackEvent += OnAttack;
        _inputReader.attackCanceledEvent += OnAttackCanceled;

    }
    private void OnDisable()
    {
        _inputReader.moveEvent -= OnMove;
        _inputReader.startRunning -= OnStartRunning;
        _inputReader.stopRunning -= OnStopRunning;
        _inputReader.jumpEvent -= OnJumpTrigger;
        _inputReader.crouchEvent -= OnCrouching;
        _inputReader.crouchStopEvent -= StopCrouching;
        _inputReader.attackEvent -= OnAttack;
        _inputReader.attackCanceledEvent -= OnAttackCanceled;
    }

    //INPUT ACTION SYSTEM

    public void OnAiming(InputAction.CallbackContext value)
    {
        if (value.performed != m_isAiming)
        {
            setAim(value.performed);
        }
        if (value.performed) Aim();
    }

    // Start is called before the first frame update
    void Awake()
    {
        playerAnimationBehaviour.SetupBehaviour();
    }

    // Update is called once per frame
    void Update()
    {
        CaculateMovementVelocity();
        UpdatePlayerMovement();
        UpdatePlayerMovementAnimation();
    }

    void CaculateMovementVelocity()
    {
        float rawInputMagnitude = rawInputMovement.magnitude;
        if (rawInputMagnitude > 0) isMoving = true; else isMoving = false;

        if (slideCountDown <= 0)
        {
            if (rawInputMagnitude > 0)
            {
                if (!isCrouching)
                {
                    if (velocity <= normalRunSpeed)
                    {
                        velocity += Time.deltaTime * acceleration;
                    }
                    if (sprintPressed && velocity <= sprintSpeed)
                    {
                        velocity += Time.deltaTime * acceleration;
                        if (velocity > sprintSpeed) velocity = sprintSpeed;
                    }
                    if (!sprintPressed && velocity > normalRunSpeed)
                    {
                        velocity -= Time.deltaTime * decceleration;
                        if (velocity < normalRunSpeed) velocity = normalRunSpeed;
                    }
                }
                if (isCrouching)
                {
                    if (velocity > crouchSpeed)
                    {
                        velocity -= Time.deltaTime * decceleration;
                        if (velocity < crouchSpeed) velocity = crouchSpeed;
                    }
                    if (velocity < crouchSpeed)
                    {
                        velocity += Time.deltaTime * acceleration;
                        if (velocity > crouchSpeed) velocity = crouchSpeed;
                    }
                }
            }
            if (rawInputMagnitude <= 0f && velocity > 0f)
            {
                velocity -= Time.deltaTime * decceleration;
                if (velocity < 0) velocity = 0f;
            }
        }

        if (slideCountDown > 0f)
        {
            slideCountDown -= Time.deltaTime;
            velocity -= Time.deltaTime * slideDecceleration;
            if (velocity < 0) velocity = 0;
        }
    }
    void setAim(bool aim)
    {
        m_isAiming = aim;
        if (aim)
        {
            transform.rotation = Quaternion.Euler(0f, gameCam.m_XAxis.Value, 0f);
            aimCam.m_Priority = 11;
            DOVirtual.Float(aimRig.weight, 1f, 0.2f, setAimRigWeight);
        }
        else
        {
            aimCam.m_Priority = 1;
            DOVirtual.Float(aimRig.weight, 0, 0.2f, setAimRigWeight);
        }
        void setAimRigWeight(float weight)
        {
            aimRig.weight = weight;
        }
    }
    void Aim()
    {
        var rot = aimTarget.localRotation.eulerAngles;
        rot.x -= cameraInput.y;
        if (rot.x > 180) rot.x -= 360;
        rot.x = Mathf.Clamp(rot.x, -80, 80);
        aimTarget.localRotation = Quaternion.Slerp(aimTarget.localRotation, Quaternion.Euler(rot), .5f);

        rot = transform.eulerAngles;
        rot.y += cameraInput.x;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rot), .5f);
    }
    void UpdatePlayerMovement()
    {
        playerMovementBehaviour.UpdateMovementData(rawInputMovement);
        isGrounded = playerMovementBehaviour.checkIfGrounded();
        playerMovementBehaviour.runSpeed = velocity;
        //Slide movement
        if (slideCountDown > 0)
            playerMovementBehaviour.isSlide(true);
        else playerMovementBehaviour.isSlide(false);
        //If WASD is null
    }

    void UpdatePlayerMovementAnimation()
    {
        playerAnimationBehaviour.UpdateVelocity(velocity);
        playerAnimationBehaviour.SetIsGrounded(isGrounded);

        //Slide movement
        if (slideCountDown > 0)
            playerAnimationBehaviour.SetIsSliding(true);
        else
            playerAnimationBehaviour.SetIsSliding(false);
        //if WASD is null
        playerAnimationBehaviour.SetIsMoving(isMoving);
        //play crouch
        playerAnimationBehaviour.PlayCrouchAnimation(isCrouching);
    }

    //--- Event Listener ---

    private void OnMove(Vector2 movement)
    {
        movement = movement.normalized;
        rawInputMovement = new Vector3(movement.x, 0, movement.y);
    }

    private void OnStartRunning()
    {
        sprintPressed = true;
    }
    private void OnStopRunning()
    {
        sprintPressed = false;
    }
    private void OnJumpTrigger()
    {
        if (isGrounded)
        {
            playerAnimationBehaviour.ResetTriggerJumpAnimation();
            playerAnimationBehaviour.TriggerJumpAnimation();
            playerMovementBehaviour.Jump();
        }
    }
    private void OnCrouching()
    {
        if (velocity >= 7f && slideCountDown <= 0f)
        {
            velocity += 5;
            slideCountDown = slideTime;
        }
        isCrouching = true;
    }
    private void StopCrouching()
    {
        isCrouching = false;
    }
    private void OnAttack(){
        attackInput = true;
        attack();
    }
    private void OnAttackCanceled(){
        attackInput = false;
    }
    void attack(){
        Collider[] hitEnemies = Physics.OverlapSphere(hitPoint.position, attackRange, enemyLayers);
        foreach(Collider enemy in hitEnemies){
            Debug.Log("We hit: " + enemy.name);
        }
    }
    void OnDrawGizmosSelected() {
        if(hitPoint == null){
            return;
        }
        Gizmos.DrawWireSphere(hitPoint.position, attackRange);
    }
}