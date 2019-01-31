using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour
{

    public Transform Reset;
    public GameObject Cloud;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<CloudAttackSequence>().FinishThis();
            other.GetComponent<Fear>().Dead();
            other.transform.position = Reset.position;
            other.GetComponent<Animator>().SetBool("Fading",true);
            Cloud.GetComponent<Animator>().SetBool("HasWon", true);
        }

    }
}
