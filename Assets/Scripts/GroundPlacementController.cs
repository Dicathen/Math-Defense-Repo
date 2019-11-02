using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class GroundPlacementController : MonoBehaviour
{
    [SerializeField] private GameObject[] placeableObjectPrefab;

    //[SerializeField] private KeyCode newObjectHotKey = KeyCode.A;

    private GameObject currentPlaceableObject;

    public GameObject range;

    public GameObject myButton;

    public Material transparent;
    
    Vector3 postion = new Vector3(0,0,0);
    private Vector3 pos;


    // Update is called once per frame
    private void Update()
    {
        HandleNewObjectHotKey();

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Physics.Raycast(ray, out var hit);
        var selection = hit.transform;
        if (currentPlaceableObject != null)
        { 
            MoveCurrentPlaceableObjectToMouse();
        }
    }

    private void ReleaseIfClicked()
    {
        if (Input.GetMouseButtonDown(0) && currentPlaceableObject.transform.position.y <= 1)
        {
            // this places towers down and adds colliders to the towers in order to set boundaries
            myButton.SetActive(true);
            currentPlaceableObject.AddComponent<BoxCollider>();
            BoxCollider collider = currentPlaceableObject.GetComponent<BoxCollider>();
            collider.size = new Vector3(3f, 5f, 3f);
            currentPlaceableObject.tag = "Defense";
            Vector3 coordinates = currentPlaceableObject.transform.position;
            coordinates.y = 1f;
            GameObject gameObject = Instantiate(range, coordinates, transform.rotation);
            //gameObject
            gameObject.GetComponent<Renderer>().material = transparent;
            currentPlaceableObject = null;
        }
    }

    private void MoveCurrentPlaceableObjectToMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo) && (currentPlaceableObject.transform.position.y <= 1) && (hitInfo.collider.tag != "Defense" && hitInfo.collider.tag != "VelocityInitial"))
        {
            if (Input.mousePosition.z <= 1)
            {
                currentPlaceableObject.transform.position = hitInfo.point;
                pos = currentPlaceableObject.transform.position;
                ReleaseIfClicked();
            }
        }
        else
        {
            if (hitInfo.collider.tag == "Defense" || hitInfo.collider.tag == "VelocityInitial")
                pos.y = 1f;
            pos = new Vector3(pos.x, pos.y-.1f, pos.z);
            //pos = currentPlaceableObject.transform.position;
            currentPlaceableObject.transform.position = pos;
        }
    }

    private void HandleNewObjectHotKey()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                // This says what tower is called by using tags
                for (int i = 0; i < 15; i++)
                {
                    String button = "Buttons" + i;
                    if (hitInfo.collider.gameObject.tag == button)
                    {
                        currentPlaceableObject = Instantiate(placeableObjectPrefab[i]);
                    }
                }
            }
        }
    }
}