using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloudAttackVisualTimer : MonoBehaviour
{

    public Text cloudTimer;
    public GameObject Cloud;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float time = Cloud.GetComponent<Animator>().GetFloat("TimerToAttack");

        cloudTimer.text = time.ToString("f1") + "s" ;
    }
}
