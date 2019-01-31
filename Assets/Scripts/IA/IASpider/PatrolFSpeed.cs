using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolFSpeed : StateMachineBehaviour
{

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;
        float Dist = Vector3.Distance(Player.position, animator.gameObject.transform.position);

        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(Player.transform.position);
        animator.gameObject.GetComponent<NavMeshAgent>().speed = 4;

 
 

    
        if (Dist < animator.GetFloat("Dist2") )
            animator.SetInteger("PatrolNum", 2);

        animator.SetFloat("DistanceToPlayer", Dist);
        if (Dist > animator.GetFloat("Dist1"))
            animator.SetInteger("PatrolNum", 0);
    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}
}
