using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Craftingtest : MonoBehaviour
{

    public GameObject PanelEins;
    public GameObject PanelZwei;

    private bool offen = true;
    private bool offenzwei = false;
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

        }

        

    }
}
