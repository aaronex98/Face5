using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopNPC : MonoBehaviour
{
    public GameObject NPC;
    public Transform HitCont;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Physics.Raycast(transform.position, HitCont.TransformDirection(Vector3.forward), out hit, 5);
        if (NPC.GetComponent<Animator>().GetBool("NPCActive"))
        {
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == NPC)
            {
                gameObject.GetComponent<Sequence>().enabled = true;
                gameObject.GetComponent<Sequence>().FirstText();
            }




        }




    }
}
