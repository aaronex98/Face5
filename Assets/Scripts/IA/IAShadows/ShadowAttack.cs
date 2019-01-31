using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShadowAttack : StateMachineBehaviour
{
    public  Vector3 InPos;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;

        InPos = animator.transform.position;

        animator.gameObject.transform.position = new Vector3(Player.localPosition.x - Random.Range(0, 5), animator.gameObject.transform.position.y, Player.localPosition.z - Random.Range(0, 5));
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;
     
        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(Player.position); 
        float distToPlayer = Vector3.Distance(Player.position, animator.gameObject.transform.position);

        if (distToPlayer < 0.5f)
        {
            animator.SetBool("IsTimeOver", false);


        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.gameObject.transform.position = InPos;
        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(InPos);
    }


}
