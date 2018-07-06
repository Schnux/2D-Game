using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Craftingtest : MonoBehaviour
{

    public GameObject PanelEins;
    public GameObject PanelZwei;
    public GameObject PanelDrei;
    private bool offen = true;
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
        { PanelEins.gameObject.SetActive(true);
            
            offen = true;
            PanelZwei.gameObject.SetActive(false);
            offenzwei = false;
            PanelZwei.gameObject.SetActive(false);
            offendrei = false;
        }

        

    }
    public void hideshowPanelzwei()
    {


        if (offenzwei == true)
        { PanelZwei.gameObject.SetActive(false);
            offenzwei = false;
        }
        else
        { PanelZwei.gameObject.SetActive(true);
            offenzwei = true;
            PanelEins.gameObject.SetActive(false);
            offen = false;
            PanelZwei.gameObject.SetActive(false);
            offendrei = false;
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
            PanelDrei.gameObject.SetActive(true);
            offendrei = true;
            PanelEins.gameObject.SetActive(false);
            offen = false;
            PanelZwei.gameObject.SetActive(false);
            offenzwei = false;

        }



    }
}
