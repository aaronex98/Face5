using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Panic : StateMachineBehaviour
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform Panel = GameObject.Find("PanelPos").transform;
        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(Panel.position);

        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;

        float Timer = Player.gameObject.GetComponent<HealthTimer>().healthTimer;
        if (Timer > 0)
        {
        Timer = Timer - Time.deltaTime;

        Player.gameObject.GetComponent<HealthTimer>().healthTimer = Timer;
        }

        if (Timer <= 0)
            SceneManager.LoadScene("Claustrofobia");

    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;

        Player.GetComponent<Sequence>().CounterForCalm = 0;
        
        Transform OPos = animator.gameObject.GetComponent<NPCPos>().Pos;
        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(OPos.position);

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
