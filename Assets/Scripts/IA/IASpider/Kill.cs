using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : StateMachineBehaviour
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform Player = GameObject.FindGameObjectWithTag("Player").transform;
        Transform Reset = GameObject.Find("ResetPoint").transform;

        Player.position = new Vector3(Reset.position.x, Player.position.y, Reset.position.z);

        Player.gameObject.GetComponent<Animator>().SetBool("Fading", true);

        Player.gameObject.GetComponent<Fear>().Dead();
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }


}
