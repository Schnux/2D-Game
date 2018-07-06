using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Craftingtest : MonoBehaviour
{

    public GameObject PanelEins;
    public GameObject PanelZwei;
    public GameObject PanelDrei;
    private bool offen = false;
    private bool offenzwei = false;
    private bool offendrei = false;
    public void Update()
    {
        

    }
    public void hideshowPanel()
    {


        if (offen == true)
        { PanelEins.gameObject.SetActive(false);
            offen = false;
        }
        else
        {
            PanelZwei.gameObject.SetActive(false);
            offenzwei = false;
            PanelDrei.gameObject.SetActive(false);
            offendrei = false;
            PanelEins.gameObject.SetActive(true);
          offen = true;
            
        }

        

    }
    public void hideshowPanelzwei()
    {


        if (offenzwei == true)
        { PanelZwei.gameObject.SetActive(false);
            offenzwei = false;
        }
        else
        {
            PanelEins.gameObject.SetActive(false);
            offen = false;
            PanelDrei.gameObject.SetActive(false);
            offendrei = false;
            PanelZwei.gameObject.SetActive(true);
            offenzwei = true;
            
        }

        

    }
    public void hideshowPaneldrei()
    {


        if (offendrei == true)
        {
            PanelDrei.gameObject.SetActive(false);
            offendrei = false;
        }
        else
        {
            PanelEins.gameObject.SetActive(false);
            offen = false;
            PanelZwei.gameObject.SetActive(false);
            offenzwei = false;
            PanelDrei.gameObject.SetActive(true);
            offendrei = true;
           
        }



    }
}
