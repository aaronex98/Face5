using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCIdle : StateMachineBehaviour
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform OPos = animator.gameObject.GetComponent<NPCPos>().Pos;
        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(OPos.position);

    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float Timer = animator.GetFloat("Timer");

        Timer = Timer - Time.deltaTime;

        animator.SetFloat("Timer", Timer);

        if (Timer <= 0)
        {

            animator.SetBool("NPCActive", true);
            animator.SetFloat("Timer", 20);
        }


    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {



    }

    
}
