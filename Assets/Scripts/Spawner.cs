using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using static PathCreator;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject[] spwnee;
    
   
    private float timeSeperation = .5f;
    private int spawnlet = 0;
    private Boolean letSpawn = false;

    // Update is called once per frame
    private void Start()
    {
        
    }

    void Update()
    {
        letSpawn = true;

        if (letSpawn == true)
        {
            if (timeSeperation <= 0)
            {
                Instantiate(spwnee[spawnlet], spawnPos.position, spawnPos.rotation);
                timeSeperation = .5f;
            }

            timeSeperation -= Time.deltaTime;
        }
        

            if (Time.timeSinceLevelLoad > 74)
        {
            spawnlet = 1;
        }
        
    }
    
}