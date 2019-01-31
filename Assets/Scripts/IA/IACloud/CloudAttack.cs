using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CloudAttack : StateMachineBehaviour
{




    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(animator.gameObject.transform.position);

        animator.SetBool("HasWon", false);
        GameObject Player = GameObject.FindGameObjectWithTag("Player");

        Player.GetComponent<CloudAttackSequence>().num = Random.Range(0, 2);
        Player.GetComponent<CloudAttackSequence>().WhatImg[Player.GetComponent<CloudAttackSequence>().num].SetActive(true);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        animator.gameObject.GetComponent<NavMeshAgent>().SetDestination(animator.gameObject.transform.position);
        GameObject Player = GameObject.FindGameObjectWithTag("Player");

        Player.GetComponent<Movement>().enabled = false;
        Player.GetComponent<Jump>().enabled = false;
        Player.GetComponent<CloudAttackSequence>().enabled = true;
        




    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        Player.GetComponent<Movement>().enabled = true;
        Player.GetComponent<Jump>().enabled = true;
        Player.GetComponent<CloudAttackSequence>().enabled = false;


    }

}
