using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsElection : MonoBehaviour
{
    bool KillPill = false;
    public string level;
    public GameObject Door;
    void Start()
    {

    }
    void Update()
    {
        if (KillPill)
            Destroy(gameObject, 4);
    }

    public void LevelElection()
    {


        Door.GetComponent<LevelChanger>().LvlElected = level;

    }
    public void PillDestroyer()
    {

        KillPill = true;

    }
}
