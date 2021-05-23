using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [Header("Sub behaviours")]
    public PlayerAnimationBehaviour playerAnimationBehaviour;

    [Header("Input Setting")]
    public Transform cam;
    public PlayerInput input;
    private bool sprintPressed = false;
    private bool crouchPressed = false;

    [Header("Movements")]
    public float velocity = 0f;
    public float acceleration = 0.1f;
    public float decceleration = 1f;
    private Vector3 rawInputMovement;

    //INPUT ACTION SYSTEM
    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 inputMovement = value.ReadValue<Vector2>();
        rawInputMovement = new Vector3(inputMovement.x, 0, inputMovement.y);
    }

    public void OnRunning(InputAction.CallbackContext value)
    {
        if (value.started) sprintPressed = true;
        if (value.canceled) sprintPressed = false;
    }

    public void OnCrouching(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            playerAnimationBehaviour.PlayCrouchAnimation(true);
        }
        if (value.canceled)
        {
            playerAnimationBehaviour.PlayCrouchAnimation(false);
        }
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

        if (rawInputMagnitude > 0)
        {
            if (velocity <= 0.5)
            {
                velocity += Time.deltaTime * acceleration;
            }
            if (sprintPressed && velocity <= 1)
            {
                velocity += Time.deltaTime * acceleration;
            }
        }
        if (rawInputMagnitude > 0 && !sprintPressed && velocity > 0.5f)
        {
            velocity -= Time.deltaTime * decceleration;
            if (velocity < 0.5f) velocity = 0.5f;
        }
        if (rawInputMagnitude <= 0 && velocity > 0f)
        {
            velocity -= Time.deltaTime * decceleration;
        }
    }

    void UpdatePlayerMovement()
    {
    }

    void UpdatePlayerMovementAnimation()
    {
        playerAnimationBehaviour.UpdateVelocity(velocity);

    }

}
