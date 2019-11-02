using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class PathCreator : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    private int current;
    public static int timeSeperation;


    void Update()
    {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % target.Length;
    }

    void OnTriggerEnter(Collider other)
    {

        /*if (other.gameObject.CompareTag("Inverse"))
        {
            var tokenSource = new CancellationTokenSource();
            slowdown(tokenSource.Token);
            tokenSource.Cancel();
        }
        */
        if (other.gameObject.CompareTag("Inverse")) speed = 3;
        if (other.gameObject.CompareTag("VelocityInitial")) speed = 10;
    }

    private void OnTriggerExit(Collider other)
     {
         if (other.gameObject.CompareTag("Inverse"))
         {
             var tokenSource = new CancellationTokenSource();
             slowdown(tokenSource.Token);
             tokenSource.Cancel();
         }
     }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("No-No Zone")) Destroy(other);
        
    }

    private async void slowdown(CancellationToken token)
     {
         while (!token.IsCancellationRequested)
         {
             for (int i = 2; i <=9; i++)
             {
                 await Task.Delay(1);
                 speed = i;
             }
             await Task.Delay(10);
             speed = 10;
         }
     }

     public void changeSpeed(int WantedSpeed)
     {
         speed = WantedSpeed;
     }

}