using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Craftingpanelszwei : MonoBehaviour
{
    public Inventory inventory;
    public GameObject PanelEins;
    public GameObject PanelZwei;
    public GameObject PanelDrei;
    public GameObject PanelVier;
    public GameObject PanelFuenf;
    public GameObject PanelSechs;
    public GameObject PanelSieben;
    public GameObject BenoetigtText;
    private bool offen = false;
    private bool offenzwei = false;
    private bool offendrei = false;
    private bool offenvier = false;
    private bool offenfuenf = false;
    private bool offensechs = false;
    private bool offensieben = false;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            inventory = FindObjectOfType<Inventory>();
            anfangpanel();

        }
    }

    public void anfangpanel()
    {


        if (inventory.copperorecraft >= 1)
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
            BenoetigtText.gameObject.SetActive(false);


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
            BenoetigtText.gameObject.SetActive(true);


        }


    }
    public void hideshowPanel()  // Copper
    {


        if (offen == true)
        { PanelEins.gameObject.SetActive(false);
            offen = false;
            BenoetigtText.gameObject.SetActive(false);
        }
        else if(offen == false && inventory.copperorecraft >= 1)
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
            BenoetigtText.gameObject.SetActive(false);

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
            BenoetigtText.gameObject.SetActive(true);

        }



    }
    public void hideshowPanelzwei() // Iron
    {


        if (offenzwei == true)
        { PanelZwei.gameObject.SetActive(false);
            offenzwei = false;
            BenoetigtText.gameObject.SetActive(false);
        }
        else if (offenzwei == false && inventory.ironorecraft >= 1)
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
            BenoetigtText.gameObject.SetActive(false);

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
            BenoetigtText.gameObject.SetActive(true);

        }



    }
    public void hideshowPaneldrei() //axt
    {


        if (offendrei == true)
        {
            PanelDrei.gameObject.SetActive(false);
            offendrei = false;
            BenoetigtText.gameObject.SetActive(false);
        }
        else if (offendrei == false && inventory.ironingotcraft >= 3 && inventory.stickscraft >= 2)
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
            BenoetigtText.gameObject.SetActive(false);

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
            BenoetigtText.gameObject.SetActive(true);

        }



    }
    public void hideshowPanelVier() //pickaxe
    {


        if (offenvier == true)
        {
            PanelVier.gameObject.SetActive(false);
            offenvier = false;
            BenoetigtText.gameObject.SetActive(false);
        }
        else if (offenvier == false && inventory.ironingotcraft >= 3 && inventory.stickscraft >= 2)
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
            BenoetigtText.gameObject.SetActive(false);

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
            BenoetigtText.gameObject.SetActive(true);

        }



    }
    public void hideshowPanelFuenf() //shovel
    {


        if (offenfuenf == true)
        {
            PanelFuenf.gameObject.SetActive(false);
            offenfuenf = false;
            BenoetigtText.gameObject.SetActive(false);
        }
        else if (offenfuenf == false && inventory.ironingotcraft >= 1 && inventory.stickscraft >= 2)
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
            BenoetigtText.gameObject.SetActive(false);

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
            BenoetigtText.gameObject.SetActive(true);

        }



    }
    public void hideshowPanelSechs() //wood
    {


        if (offensechs == true)
        {
            PanelSechs.gameObject.SetActive(false);
            offensechs = false;
            BenoetigtText.gameObject.SetActive(false);
        }
        else if (offensechs == false && inventory.logcraft >= 1)
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
            BenoetigtText.gameObject.SetActive(false);

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
            BenoetigtText.gameObject.SetActive(true);

        }



    }
    public void hideshowPanelSieben() //sticks
    {


        if (offensieben == true)
        {
            PanelSieben.gameObject.SetActive(false);
            offensieben = false;
            BenoetigtText.gameObject.SetActive(false);
        }
        else if (offensieben == false && inventory.plankscraft >= 2)
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
            BenoetigtText.gameObject.SetActive(false);

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
            BenoetigtText.gameObject.SetActive(true);
        }



    }

}
