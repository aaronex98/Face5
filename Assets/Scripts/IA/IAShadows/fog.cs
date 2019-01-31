using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fog : MonoBehaviour
{

    public GameObject Light;
    public GameObject Text;
    public Text TimerText;
    public float Timer;
    public bool ReduceTime;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.fogDensity = 0.05f;

        if (Input.GetKeyDown(KeyCode.F) && Timer > 0)
        {
            Light.GetComponent<Light>().intensity = 4;
            Light.GetComponent<Light>().range = 35;
            Light.GetComponent<Light>().spotAngle = 110;
            Text.SetActive(false);
            ReduceTime = true;
        }
        else if (Input.GetKeyDown(KeyCode.C) && Timer > 0)
        {

            Light.GetComponent<Light>().intensity = 2;
            Light.GetComponent<Light>().range = 15;
            Light.GetComponent<Light>().spotAngle = 80;

            Text.SetActive(false);
            ReduceTime = false;
        }
        if (ReduceTime && Timer > 0)
        {
            Timer = Timer - Time.deltaTime;



        }
     
        TimerText.text = Timer.ToString("f1") + "s";
        if (Timer < 1)
        {
            Light.GetComponent<Light>().intensity = 2;
            Light.GetComponent<Light>().range = 15;
            Light.GetComponent<Light>().spotAngle = 80;


        }
    }
}
