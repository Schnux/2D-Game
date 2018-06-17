using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour {

    public GameObject CR;
	
	
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.C))
        {
            if (Pause_pause.stopped == true)
            {
                continuC();
            }
            else
            {
                stopC();
            }
        }

        if (Time.timeScale == 1f)
        {
            CR.SetActive(false);
        }
	}

    public void continuC ()
    {
        CR.SetActive(false);
        Time.timeScale = 1f;
        Pause_pause.stopped = false; 
    }

    public void stopC ()
    {
        CR.SetActive(true);
        Time.timeScale = 0f;
        Pause_pause.stopped = true;
    }
}
