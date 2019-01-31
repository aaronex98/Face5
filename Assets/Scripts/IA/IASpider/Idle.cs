using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Idle : StateMachineBehaviour
{



    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetFloat("TimerToIdle", 25);

            
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;

        float timer = animator.GetFloat("TimerToPatrol");

        float Dist = Vector3.Distance(Player.position, animator.gameObject.transform.position);

        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(animator.gameObject.transform.position);

        if (Dist < animator.GetFloat("Dist1"))
            animator.SetInteger("PatrolNum", 1);

        animator.SetFloat("DistanceToPlayer", Dist);

        timer = timer - Time.deltaTime;
        animator.SetFloat("TimerToPatrol", timer);






    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }


}
