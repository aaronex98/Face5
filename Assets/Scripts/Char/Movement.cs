using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject DirCont;
    private Vector3 PlayerForward;
    private Vector3 PlayerRight;
    [Range(0, 10)]public float Speed;


    void Start()
    {
      
    }

    // Update is called once per framewa
    void FixedUpdate()
    {
        PlayerForward = DirCont.GetComponent<DirControl>().transform.forward;
        PlayerRight = DirCont.GetComponent<DirControl>().transform.right;



        
        if (Input.GetKey(KeyCode.W))
            transform.Translate(PlayerForward * Speed* Time.deltaTime );

        if (Input.GetKey(KeyCode.S))
            transform.Translate(-PlayerForward *Speed* Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(-PlayerRight * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(PlayerRight * Speed * Time.deltaTime);

    }






}
