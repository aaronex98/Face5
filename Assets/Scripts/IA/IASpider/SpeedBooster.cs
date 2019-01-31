using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    [Range(0, 10)]public float BoostedSpeed;
    float OriginalSpeed;
    // Use this for initialization
    void Start()
    {
        OriginalSpeed = gameObject.GetComponent<Movement>().Speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            gameObject.GetComponent<Movement>().Speed = BoostedSpeed;

        if (Input.GetKeyUp(KeyCode.LeftShift))
            gameObject.GetComponent<Movement>().Speed = OriginalSpeed;
    }
}
