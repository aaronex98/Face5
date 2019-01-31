using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CloudAttackSequence : MonoBehaviour
{

    public GameObject Left;
    public GameObject Right;
    public GameObject[] WhatImg;
    public int NumberOfTouches;
    public GameObject Cloud;
    public float timer;
    public float ResetTime;
    public int num;

    void Start()
    {

       

        timer = ResetTime;
   
    }

    void Update()
    {
        
        timer = timer - Time.deltaTime;
       
        if (Left.activeSelf == true)
        {

            if (Input.GetKeyDown(KeyCode.A))
            {
                num = Random.Range(0, 2);
                Left.SetActive(false);
                WhatImg[num].SetActive(true);
                NumberOfTouches++;
                timer = ResetTime;
            }

            else if (Input.GetKeyDown(KeyCode.D))
            {
            
                Cloud.GetComponent<Animator>().SetBool("HasWon", true);
                gameObject.transform.localPosition = new Vector3(100, transform.localPosition.y,100);
                FinishThis();


            }
        }
        else if (Right.activeSelf == true)
        {

            if (Input.GetKeyDown(KeyCode.D))
            {
                  num = Random.Range(0, 2);
                Right.SetActive(false);
                WhatImg[num].SetActive(true);
                NumberOfTouches++;
                timer = ResetTime;
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
         
                Cloud.GetComponent<Animator>().SetBool("HasWon", true);
                gameObject.transform.localPosition = new Vector3(100, transform.localPosition.y, 100);
                FinishThis();

            }


        }






        if (NumberOfTouches > 7)
        {
          
            Cloud.GetComponent<Animator>().SetBool("HasWon", true);
            FinishThis();


        }

        if (timer < 0)
        {
            if (Right.activeSelf == true)
            {
           
                Cloud.GetComponent<Animator>().SetBool("HasWon", true);
                gameObject.transform.localPosition = new Vector3(100, transform.localPosition.y, 100);
                FinishThis();


            }
            if (Left.activeSelf == true)
            {
          
                Cloud.GetComponent<Animator>().SetBool("HasWon", true);
                gameObject.transform.localPosition = new Vector3(100, transform.localPosition.y, 100);
                FinishThis();

            }


           
        }
        
    }
    
    public void FinishThis()
    {
        
        NumberOfTouches = 0;
        Left.SetActive(false);
        Right.SetActive(false);
        timer = ResetTime;
       
        gameObject.GetComponent<CloudAttackSequence>().enabled = false;

    }
}
