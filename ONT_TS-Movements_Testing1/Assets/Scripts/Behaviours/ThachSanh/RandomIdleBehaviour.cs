using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomIdleBehaviour : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        int randomIdle = Random.Range(0, 3);
        Debug.Log("randomIdle: " + randomIdle);
        animator.SetInteger("randomIdle", randomIdle);
    }
}
