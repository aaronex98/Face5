using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class CloudPatrol : StateMachineBehaviour
{
    public bool HasGoneback;
    public float timertoattack;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        animator.SetBool("HasWon", false);
        HasGoneback = false;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timertoattack = animator.GetFloat("TimerToAttack");
        animator.SetBool("HasWon", false);
        timertoattack = timertoattack - Time.deltaTime;

        animator.SetFloat("TimerToAttack", timertoattack);
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
       

        float Distance = Vector3.Distance(Player.transform.position, animator.gameObject.transform.position);

        animator.SetFloat("Distance", Distance);



        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(Player.transform.position);


         


     
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        timertoattack = 10f;

        animator.SetFloat("TimerToAttack", timertoattack);
    }


}
