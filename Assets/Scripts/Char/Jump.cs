using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool isJumping = false;
    [Range(0, 10)] public float forceJump;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        RaycastHit hit;
        bool ray = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 2.7f);

        if (ray && Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {



            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, forceJump, 0), ForceMode.Impulse);
            isJumping = true;


        }

        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            isJumping = false;

        }
    }
}
