using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAttack : MonoBehaviour
{
    public int EnemysKilled;
    public GameObject[] EnemysSpawn;
    public Transform HitCont;
    public GameObject[] Enemys;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        Physics.Raycast(transform.position, HitCont.TransformDirection(Vector3.forward), out hit, 5);
        Debug.DrawRay(transform.position, HitCont.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[0] )
        {
            Ataque();
            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[1])
        {
            Ataque();

            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[2])
        {
            Ataque();
            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[3])
        {
            Ataque();
            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[4])
        {
            Ataque();
            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[5])
        {
            Ataque();
            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[6])
        {
            Ataque();
            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[7])
        {
            Ataque();
            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[8])
        {
            Ataque();
            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[9])
        {
            Ataque();
            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[10])
        {
 hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
            Ataque();
            Debug.Log("Hit");
           
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Enemys[11])
        {
            Ataque();
            Debug.Log("Hit");
            hit.collider.gameObject.GetComponent<Animator>().SetBool("UniDeath", true);
            
        }

        if (EnemysKilled == 30)
        {

            EnemysSpawn[0].SetActive(false);
            EnemysSpawn[1].SetActive(false);
            EnemysSpawn[2].SetActive(false);


        }

    }
    public void Ataque()
    {
        EnemysKilled = EnemysKilled+ 1;
    }
}
