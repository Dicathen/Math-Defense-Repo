using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static PathCreator;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject[] spwnee;

    private float timeSeperation = 1;
    private int spawnlet = 0;
    private Boolean letSpawn = false;

    // Update is called once per frame
    void Update()
    {
        //PathCreator bob = new PathCreator();

        if (letSpawn == true)
        {
            if (timeSeperation <= 0)
            {
                Instantiate(spwnee[spawnlet], spawnPos.position, spawnPos.rotation);
                timeSeperation = 1f;
            }

            timeSeperation -= Time.deltaTime;
        }
        
        if (Time.timeSinceLevelLoad > 14)
        {
            letSpawn = true;
        }

        if (Time.timeSinceLevelLoad > 74)
        {
            spawnlet = 1;
        }
    }
    
}