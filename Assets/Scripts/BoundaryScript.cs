using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -15f,0f), 1f, Mathf.Clamp(transform.position.z, -7.5f, 7.5f));
//Mathf.Clamp(transform.position.y, 1f,1.1f)
    }
}
