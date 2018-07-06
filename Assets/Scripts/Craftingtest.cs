using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Craftingtest : MonoBehaviour
{

    public GameObject PanelEins;
    public GameObject PanelZwei;
    public GameObject PanelDrei;
    public GameObject PanelVier;
    public GameObject PanelFuenf;
    public GameObject PanelSechs;
    public GameObject PanelSieben;
    private bool offen = false;
    private bool offenzwei = false;
    private bool offendrei = false;
    private bool offenvier = false;
    private bool offenfuenf = false;
    private bool offensechs = false;
    private bool offensieben = false;
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
            PanelVier.gameObject.SetActive(false);
            offenvier = false;
            PanelFuenf.gameObject.SetActive(false);
            offenfuenf = false;
            PanelSechs.gameObject.SetActive(false);
            offensechs = false;
            PanelSieben.gameObject.SetActive(false);
            offensieben = false;
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
            PanelVier.gameObject.SetActive(false);
            offenvier = false;
            PanelFuenf.gameObject.SetActive(false);
            offenfuenf = false;
            PanelSechs.gameObject.SetActive(false);
            offensechs = false;
            PanelSieben.gameObject.SetActive(false);
            offensieben = false;
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
            PanelVier.gameObject.SetActive(false);
            offenvier = false;
            PanelFuenf.gameObject.SetActive(false);
            offenfuenf = false;
            PanelSechs.gameObject.SetActive(false);
            offensechs = false;
            PanelSieben.gameObject.SetActive(false);
            offensieben = false;
            PanelDrei.gameObject.SetActive(true);
            offendrei = true;
           
        }



    }
    public void hideshowPanelVier()
    {


        if (offenvier == true)
        {
            PanelVier.gameObject.SetActive(false);
            offenvier = false;
        }
        else
        {
            PanelEins.gameObject.SetActive(false);
            offen = false;
            PanelZwei.gameObject.SetActive(false);
            offenzwei = false;
            PanelDrei.gameObject.SetActive(false);
            offendrei = false;
            PanelFuenf.gameObject.SetActive(false);
            offenfuenf = false;
            PanelSechs.gameObject.SetActive(false);
            offensechs = false;
            PanelSieben.gameObject.SetActive(false);
            offensieben = false;
            PanelVier.gameObject.SetActive(true);
            offenvier = true;

        }



    }
    public void hideshowPanelFuenf()
    {


        if (offenfuenf == true)
        {
            PanelFuenf.gameObject.SetActive(false);
            offenfuenf = false;
        }
        else
        {
            PanelEins.gameObject.SetActive(false);
            offen = false;
            PanelZwei.gameObject.SetActive(false);
            offenzwei = false;
            PanelDrei.gameObject.SetActive(false);
            offendrei = false;
            PanelVier.gameObject.SetActive(false);
            offenvier = false;
            PanelSechs.gameObject.SetActive(false);
            offensechs = false;
            PanelSieben.gameObject.SetActive(false);
            offensieben = false;
            PanelFuenf.gameObject.SetActive(true);
            offenfuenf = true;

        }



    }
    public void hideshowPanelSechs()
    {


        if (offensechs == true)
        {
            PanelSechs.gameObject.SetActive(false);
            offensechs = false;
        }
        else
        {
            PanelEins.gameObject.SetActive(false);
            offen = false;
            PanelZwei.gameObject.SetActive(false);
            offenzwei = false;
            PanelDrei.gameObject.SetActive(false);
            offendrei = false;
            PanelVier.gameObject.SetActive(false);
            offenvier = false;
            PanelFuenf.gameObject.SetActive(false);
            offenfuenf = false;
            PanelSieben.gameObject.SetActive(false);
            offensieben = false;
            PanelSechs.gameObject.SetActive(true);
            offensechs = true;

        }



    }
    public void hideshowPanelSieben()
    {


        if (offensieben == true)
        {
            PanelSieben.gameObject.SetActive(false);
            offensieben = false;
        }
        else
        {
            PanelEins.gameObject.SetActive(false);
            offen = false;
            PanelZwei.gameObject.SetActive(false);
            offenzwei = false;
            PanelDrei.gameObject.SetActive(false);
            offendrei = false;
            PanelVier.gameObject.SetActive(false);
            offenvier = false;
            PanelFuenf.gameObject.SetActive(false);
            offenfuenf = false;
            PanelSechs.gameObject.SetActive(false);
            offensechs = false;
            PanelSieben.gameObject.SetActive(true);
            offensieben = true;

        }



    }

}
