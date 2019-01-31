using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillSelector : MonoBehaviour
{
    public GameObject Camera;
    public GameObject[] Pills;
    public KeyCode Click;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
       

    

         Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1000);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Pills[0])
        {

            Pills[0].GetComponent<LevelsElection>().LevelElection();

        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject== Pills[1])
        {

            Pills[1].GetComponent<LevelsElection>().LevelElection();

        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Pills[2])
        {

            Pills[2].GetComponent<LevelsElection>().LevelElection();

        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Pills[3])
        {

            Pills[3].GetComponent<LevelsElection>().LevelElection();

        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Pills[4])
        {

            Pills[4].GetComponent<LevelsElection>().LevelElection();

        }




    }
}
