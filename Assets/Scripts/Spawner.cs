using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using TMPro;
using UnityEngine;
using static PathCreator;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject[] spwnee;
    
    
    private float timeSeperation = 1f;
    private int spawnlet = 0;
    private Boolean roundStart = false;
    private GameObject roundCounter;
    private int enemynum;
    public int roundNumber;
    private int baseEnemyNum = 10;
    private int enemyRange = 0;

    // Update is called once per frame
    private void Start()
    { 
        roundCounter = GameObject.Find("Round");
        Rounds roundScript = roundCounter.GetComponent<Rounds>();
        roundNumber = roundScript.round;
        roundStart = true;
    }

    void Update()
    {
        if (roundStart = true)
        {
            int executionTimes = 10;
            /*if (timeSeperation <= 0)
            {
                Instantiate(spwnee[0], spawnPos.position, spawnPos.rotation);
                timeSeperation = 1f;
            }
            timeSeperation -= Time.deltaTime;*/
            RoundSystem(roundNumber);
            executionTimes -= 1;
            /*if (executionTimes == 0)
            {
                roundStart = false;
                executionTimes = 10 + roundNum;
                roundNum++;
                roundCounter = GameObject.Find("Round");
                Rounds roundScript = roundCounter.GetComponent<Rounds>();
                roundScript.round += 1;
                roundStart = true;
            }*/
        }

        
        
    }

    void RoundSystem(int roundNum)
    {
        if (roundNum < 10 )
        {
            enemynum = 0;
            int spawnlimit = 10;
            if (timeSeperation <= 0)
            {
                Instantiate(spwnee[enemynum], spawnPos.position, spawnPos.rotation);
                spawnlimit -= 1;
                
                timeSeperation = 1f;
            }
            timeSeperation -= Time.deltaTime;
            if (spawnlimit == 0)
            {
                    
                roundCounter = GameObject.Find("Round");
                Rounds roundScript = roundCounter.GetComponent<Rounds>();
                roundScript.round++;
                roundNum = roundScript.round;
                roundNumber++;
                print(roundNum);
            }
        }
        if (roundNum >= 10 && roundNum < 20)
        {
            enemynum = 1;
            int spawnlimit = 10;
            if (timeSeperation <= 0)
            {
                Instantiate(spwnee[1], spawnPos.position, spawnPos.rotation);
                spawnlimit -= 1;
                if (spawnlimit == 0)
                {
                    //roundNum++;
                    roundCounter = GameObject.Find("Round");
                    Rounds roundScript = roundCounter.GetComponent<Rounds>();
                    roundScript.round++;
                    roundNum = roundScript.round;
                    print(roundNum);
                }
                timeSeperation = 1f;
            }
            timeSeperation -= Time.deltaTime;
        }
    }

    async void spawnEnemy(CancellationToken token,int roundNum)
    {
        
    }
    
}