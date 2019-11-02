using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Destroyer : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z >= 10.18888)
        {
            Destruction();
        }
    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }
    
}