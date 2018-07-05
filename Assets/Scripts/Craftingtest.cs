using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Craftingtest : MonoBehaviour
{

    public GameObject PanelEins;
    public GameObject PanelZwei;

    int offen;
    int offenzwei;
    public void Update()
    {
        

    }
    public void hideshowPanel()
    {


        if (offen % 2 == 1)
        { PanelEins.gameObject.SetActive(false); }
        else
        { PanelEins.gameObject.SetActive(true);
            PanelZwei.gameObject.SetActive(false);
            offenzwei++;
        }

        offen++;

    }
    public void hideshowPanelzwei()
    {


        if (offenzwei % 2 == 1)
        { PanelZwei.gameObject.SetActive(false);
        }
        else
        { PanelZwei.gameObject.SetActive(true);
            PanelEins.gameObject.SetActive(false);
            offen++;
        }

        offenzwei++;

    }
}
