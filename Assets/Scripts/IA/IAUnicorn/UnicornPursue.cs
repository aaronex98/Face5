using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnicornPursue : StateMachineBehaviour
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;

        float dist = Vector3.Distance(animator.gameObject.transform.position, Player.position);
        animator.SetFloat("DistanceToPlayer", dist);


        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(Player.position);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }


}
