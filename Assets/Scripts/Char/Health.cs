using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float HP;
    public float OHP;
    public Text text;
    public Transform Spawn;
    void Start()
    {

    }

    void Update()
    {
         text.text = HP + "HP";   
        if(HP == 0)
        {
            ReStart();
        }
    }
    public void ReduceHealth()
    {
        HP = HP - OHP/4;
        

    }
    public void ReStart()
    {
        HP = OHP;
        gameObject.GetComponent<CharAttack>().EnemysKilled = 0;
        gameObject.transform.position = Spawn.position;
        gameObject.GetComponent<Animator>().SetBool("Fading", true);
        gameObject.GetComponent<Fear>().Dead();

    }
}
