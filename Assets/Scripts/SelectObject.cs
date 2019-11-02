using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor.UIElements;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    //public GameObject panel;

    /*[SerializeField] private string selectableTag = "Selectable";

    [SerializeField] private Material highlightMaterial;

    [SerializeField] private Material defaultMaterial;

    private Transform _selection;*/

    public Material invisible;

    public Material shown;

    private static GameObject tower;

    private static bool iswhat = false;
    private void Update()
    {
        if (iswhat == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                tower.GetComponentInChildren<Renderer>().material = invisible;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                for (int i = 0; i < 15; i++)
                {
                    String name = "Interactable";
                    if (hit.collider.gameObject.tag == name)
                    {
                        tower = hit.collider.gameObject;
                        tower.GetComponentInChildren<Renderer>().material = shown;
                        iswhat = true;
                    }
                }
            }

        }
        


        /*if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                selectionRenderer.material = defaultMaterial;
            }
        }
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        _selection = null;
        if (Physics.Raycast(ray, out var hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                _selection = selection;
            }
        }

        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            if (selectionRenderer != null) 
            { 
                selectionRenderer.material = highlightMaterial;
            }
        }*/
            
        
    }
    

    void tearsOfPain()
    {
        for (int i = 0; i < Int32.MaxValue; i++)
        {
            print("crying noises - Carlos Ortiz");
        }
    }
}


