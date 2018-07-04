using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CraftingPanel : MonoBehaviour
{

    public GameObject Panel;
    int counter;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            showhidePanel();

    }
    public void showhidePanel()
    {


        if (counter % 2 == 1)
        { Panel.gameObject.SetActive(false); }
        else
        { Panel.gameObject.SetActive(true); }

        counter++;

    }
}
