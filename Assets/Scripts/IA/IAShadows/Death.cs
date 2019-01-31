using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject Light;
    public Transform Reset;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            transform.position = Reset.position;
            GetComponent<fog>().ReduceTime = false;
            GetComponent<fog>().Timer = 30f;
            GetComponent<Animator>().SetBool("Fading", true);
            Light.GetComponent<Light>().intensity = 2;
            Light.GetComponent<Light>().range = 15;
            Light.GetComponent<Light>().spotAngle = 80;
        }
    }
}
