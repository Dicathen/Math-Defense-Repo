using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ElapsedTime : MonoBehaviour
{
    public GameObject MyTextGameObject;
    private TextMeshProUGUI time;
    
    private void Start()
    {
        MyTextGameObject = GameObject.Find("Time");
        time = MyTextGameObject.GetComponent<TextMeshProUGUI>();
        time.text = "0" + time;
    }
    
    // Update is called once per frame
    void Update()
    {
        time.text = "" + Math.Round(Time.timeSinceLevelLoad, 1);

    }
}
