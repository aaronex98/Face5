using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fear : MonoBehaviour
{


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Shake()

    {




    }
    public void Dead()
    {

        StartCoroutine(Fade());

    }
    private IEnumerator Fade()
    {
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Animator>().SetBool("Fading", false);
    }
}
