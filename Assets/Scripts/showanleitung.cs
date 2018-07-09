using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showanleitung : MonoBehaviour
{

    public GameObject Anleitung_Bild;
    int counter = 1;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
            showhidePanel();

    }
    public void showhidePanel()
    {


        if (counter % 2 == 1)
        { Anleitung_Bild.gameObject.SetActive(false); }
        else
        { Anleitung_Bild.gameObject.SetActive(true); }

        counter++;

    }
}
