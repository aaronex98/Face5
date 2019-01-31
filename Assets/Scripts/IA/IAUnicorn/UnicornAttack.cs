using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnicornAttack : StateMachineBehaviour
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;

        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(animator.gameObject.transform.position);
        float dist = Vector3.Distance(animator.gameObject.transform.position, Player.position);
        animator.SetFloat("DistanceToPlayer", dist);

        float timeToAttack = animator.GetFloat("TimeToAttack");
        float OTA = animator.GetFloat("OriginalTA");
        if (timeToAttack> 0)
        {

            timeToAttack = timeToAttack - Time.deltaTime;
            animator.SetFloat("TimeToAttack", timeToAttack);

        }
        else if(timeToAttack <= 0)
        {

            Player.gameObject.GetComponent<Health>().ReduceHealth();
            animator.SetFloat("TimeToAttack", OTA); 



        }

    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }


}
