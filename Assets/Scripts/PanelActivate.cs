using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActivate : MonoBehaviour
{
    public GameObject panel;
    public GameObject store;
    public static bool last = false;
    
    public void PanelOpener()
    {
        if (panel != null)
        {
            bool isTrue;
            if (panel.activeSelf == true)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);

            if (panel.activeSelf == false && isTrue == true)
            { 
                last = true;
            }
        }
    }

    public void EnablingButton()
    {
        store.SetActive(false);
    }

}
