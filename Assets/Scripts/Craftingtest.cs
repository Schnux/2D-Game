using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Craftingtest : MonoBehaviour
{

    public GameObject Panel;
    int offen;

    public void Update()
    {
        

    }
    public void hideshowPanel()
    {


        if (offen % 2 == 1)
        { Panel.gameObject.SetActive(false); }
        else
        { Panel.gameObject.SetActive(true); }

        offen++;

    }
}
