using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showinventorypanel : MonoBehaviour
{

    public GameObject InventoryPanel;
    int counter = 1;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            showhidePanel();

    }
    public void showhidePanel()
    {


        if (counter % 2 == 1)
        { InventoryPanel.gameObject.SetActive(false); }
        else
        { InventoryPanel.gameObject.SetActive(true); }

        counter++;

    }
}

