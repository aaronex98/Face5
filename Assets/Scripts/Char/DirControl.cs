using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirControl : MonoBehaviour
{
    public float PlayerAngleXRot;
    [Range(0f, 10f)] public float PlayerRotVelocity;
    public GameObject Cam;
    

    void Start()
    {

    }

    void Update()
    {
        PlayerDirCont();
    }
    void PlayerDirCont()
    {
        var x = Input.GetAxis("Mouse X");

        PlayerAngleXRot += x * PlayerRotVelocity;

       transform.rotation = Quaternion.Euler(0, PlayerAngleXRot, 0);

    }
    public void SetRot()
    {

       

    }
}
