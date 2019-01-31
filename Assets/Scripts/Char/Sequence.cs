using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequence : MonoBehaviour
{
    public GameObject Img;
    public GameObject NPC;
    public int Index;
    public GameObject[] Texts;
    public int CounterForCalm;
    public KeyCode[] Buttons;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Img.SetActive(true);

        if (Img.activeSelf == true)
        {
            if (Input.GetKeyDown(Buttons[Index]))
            {
                Texts[Index].SetActive(false);
                Index = Random.Range(1, 6);
                Texts[Index].SetActive(true);
                CounterForCalm++;
                
            }

            else if (Input.GetKeyDown(KeyCode.Alpha1) && Index != 1)
            {
                gameObject.GetComponent<HealthTimer>().healthTimer = 0;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) && Index != 2)
            {
                gameObject.GetComponent<HealthTimer>().healthTimer = 0;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) && Index != 3)
            {
                gameObject.GetComponent<HealthTimer>().healthTimer = 0;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4) && Index != 4)
            {
                gameObject.GetComponent<HealthTimer>().healthTimer = 0;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5) && Index != 5)
            {
                gameObject.GetComponent<HealthTimer>().healthTimer = 0;
            }


        }
        if (CounterForCalm == 6)
        {
            gameObject.GetComponent<HealthTimer>().healthTimer = 20;
            Img.SetActive(false);
            Texts[Index].SetActive(false);
            NPC.GetComponent<Animator>().SetBool("NPCActive", false);

            gameObject.GetComponent<Sequence>().enabled = false;

        }



    }
    public void FirstText()
    {
        Index = Random.Range(1, 6);
        Texts[Index].SetActive(true);




    }
}
