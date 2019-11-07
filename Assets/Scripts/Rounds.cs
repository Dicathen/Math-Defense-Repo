using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rounds : MonoBehaviour
{
    public GameObject MyTextGameObject;
    private TextMeshProUGUI _textMesh;

    public int round =1;

    // Start is called before the first frame update
    void Start()
    {
        MyTextGameObject = GameObject.Find("Round");
        _textMesh = MyTextGameObject.GetComponent<TextMeshProUGUI>();
        _textMesh.text = "Round: " + round;
    }

    // Update is called once per frame
    void Update()
    {
        
        _textMesh.text = "Round: " + round;
        //CheckForRound();

    }

    void CheckForRound()
    {
        int roundNumber = (int)Time.timeSinceLevelLoad / 60;
        round = roundNumber + 1;
        _textMesh.text = "Round: " + round;
        
    }
}
