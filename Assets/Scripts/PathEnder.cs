using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathEnder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
