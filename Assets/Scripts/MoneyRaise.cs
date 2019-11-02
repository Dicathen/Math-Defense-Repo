using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyRaise : MonoBehaviour
{
    // Start is called before the first frame update
    private int currency = 10;
    private float timeLeft = 2;
    public GameObject MyTextGameObject; 
    private TextMeshProUGUI _textMesh;

    private void Start()
    {
        MyTextGameObject = GameObject.Find("Currency");
        _textMesh = MyTextGameObject.GetComponent<TextMeshProUGUI>();
        _textMesh.text = "Currency: $" + currency;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 )
        {
            currency += 1;
            timeLeft = 2;
            _textMesh.text = "Currency: $" + currency;
        }
    }
}
