using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicornSpawner : MonoBehaviour
{
    public GameObject[] Unicorn;
    public float timer;
    public float originalTimer;
    public int num;
    void Start()
    {




    }

    void Update()
    {
        if (timer > 0)
            timer = timer - Time.deltaTime;

        else if (timer <= 0)
        {
            Unicorn[num].SetActive(true);
            Unicorn[num].GetComponent<Animator>().SetBool("UniDeath", false);
            num++;
           
 
            timer = originalTimer;

        }
        if (num > 3)
        {
            num = 0;
        }




    }
}
