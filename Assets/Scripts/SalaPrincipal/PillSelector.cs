using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillSelector : MonoBehaviour
{
    public GameObject Camera;

    public GameObject PlayerController;

    public GameObject[] Pills;

    public GameObject PlayerDir;
    public GameObject CamController;

    bool PillEaten = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
       

    

         Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Pills[0] && !PillEaten)
        {

            Pills[0].GetComponent<LevelsElection>().LevelElection();
            Pills[0].GetComponent<LevelsElection>().PillDestroyer();
            MovementEnabled();
            IsAPillEaten();
           
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject== Pills[1] && !PillEaten)
        {

            Pills[1].GetComponent<LevelsElection>().LevelElection();
            Pills[1].GetComponent<LevelsElection>().PillDestroyer();

            MovementEnabled();
            IsAPillEaten();
           
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Pills[2] && !PillEaten)
        {

            Pills[2].GetComponent<LevelsElection>().LevelElection();
            Pills[2].GetComponent<LevelsElection>().PillDestroyer();
            MovementEnabled();
            IsAPillEaten();
           
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Pills[3] && !PillEaten)
        {

            Pills[3].GetComponent<LevelsElection>().LevelElection();
            Pills[3].GetComponent<LevelsElection>().PillDestroyer();
            MovementEnabled();
            IsAPillEaten();
            
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.gameObject == Pills[4] && !PillEaten)
        {

            Pills[4].GetComponent<LevelsElection>().LevelElection();
            Pills[4].GetComponent<LevelsElection>().PillDestroyer();
            MovementEnabled();
            IsAPillEaten();
           
        }




    }
    public void MovementEnabled()
    {

        PlayerController.GetComponent<Movement>().enabled = true;
        PlayerDir.GetComponent<DirControl>().enabled = true;
        PlayerController.transform.position = new Vector3(PlayerController.transform.position.x - 1 , PlayerController.transform.position.y + 1, PlayerController.transform.position.z);
        PlayerController.GetComponent<CapsuleCollider>().isTrigger = false;
        PlayerController.GetComponent<Rigidbody>().useGravity = true;

    }
    public void IsAPillEaten()
    {

        PillEaten = true;
        CamController.GetComponent<LimitedCamera>().enabled = false;
        CamController.GetComponent<FreeCamera>().enabled = true;
    }
    
}
