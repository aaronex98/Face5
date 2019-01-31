using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
   
    public string LvlElected;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void ChangeLevel()
    {


        SceneManager.LoadScene(LvlElected);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            ChangeLevel();
    }

}
