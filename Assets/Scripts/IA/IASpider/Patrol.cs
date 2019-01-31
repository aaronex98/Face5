using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : StateMachineBehaviour
{
    Transform[] WP = new Transform[6];


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetFloat("TimerToPatrol", 5);

        WP[0] = GameObject.Find("WayPoint").transform;
        WP[1] = GameObject.Find("WayPoint2").transform;
        WP[2] = GameObject.Find("WayPoint3").transform;
        WP[3] = GameObject.Find("WayPoint4").transform;
        WP[4] = GameObject.Find("WayPoint5").transform;
        WP[5] = GameObject.Find("WayPoint6").transform;

        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(WP[animator.GetInteger("CurrentWP")].position);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        WP[0] = GameObject.Find("WayPoint").transform;
        WP[1] = GameObject.Find("WayPoint2").transform;
        WP[2] = GameObject.Find("WayPoint3").transform;
        WP[3] = GameObject.Find("WayPoint4").transform;
        WP[4] = GameObject.Find("WayPoint5").transform;
        WP[5] = GameObject.Find("WayPoint6").transform;

        Transform CSWP = WP[animator.GetInteger("CurrentWP")];
        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;

        float Dist = Vector3.Distance(Player.position, animator.gameObject.transform.position);


        if (Dist < animator.GetFloat("Dist1"))
            animator.SetInteger("PatrolNum", 1);

        animator.SetFloat("DistanceToPlayer", Dist);

        float DistanceToWP = Vector3.Distance(animator.gameObject.transform.position, CSWP.position);


        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(CSWP.position);

      int WayPoint = animator.GetInteger("CurrentWP");

        if (DistanceToWP < 10)
        {
            if (WayPoint <= 4)
            {
                
                animator.SetInteger("CurrentWP", WayPoint + 1);
                WayPoint = WayPoint++;
            }
            if (WayPoint > 4)
            {
                animator.SetInteger("CurrentWP", 0);

                WayPoint = 0;
            }
        }

        

        animator.SetFloat("DistToWP", DistanceToWP);

        float timertoidle = animator.GetFloat("TimerToIdle");
        timertoidle = timertoidle - Time.deltaTime;
        animator.SetFloat("TimerToIdle", timertoidle);


    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

}
