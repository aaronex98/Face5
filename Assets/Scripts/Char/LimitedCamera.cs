using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedCamera : MonoBehaviour
{

    public GameObject Rig;
    

    private float Ymin = 75f;
    private float Ymax = 45f;
    private float AngleYRot;

    private float AngleXRot;
    [Range(0f, 10f)] public float RotVelocity;
   



    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;



    }
    private void Update()
    {


        LimitedRotMovement();


    }
    void LimitedRotMovement()
    {
        var x = Input.GetAxis("Mouse X");
        var y = Input.GetAxis("Mouse Y");

        AngleXRot += x * RotVelocity;
        AngleXRot = Mathf.Clamp(AngleXRot, -70, 70);

        Rig.transform.localRotation = Quaternion.Euler(0, AngleXRot, 0);

        AngleYRot -= y * RotVelocity;
        AngleYRot = Mathf.Clamp(AngleYRot, -Ymin, Ymax);

        Rig.transform.localRotation = Quaternion.Euler(AngleYRot, Rig.transform.rotation.eulerAngles.y, Rig.transform.rotation.eulerAngles.z);
    }
}
