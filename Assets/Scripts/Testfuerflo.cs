using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testfuerflo : MonoBehaviour {

    public GameObject Anleitung;
    private bool offen = false;
    public void anleitungzeigen()
    {


        if (offen == true)
        { Anleitung.gameObject.SetActive(false);
            offen = false;
        }
        else
        { Anleitung.gameObject.SetActive(true);
            offen = true;
        }

        
    }
}
