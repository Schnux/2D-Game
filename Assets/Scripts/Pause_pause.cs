using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_pause : MonoBehaviour {

    public static bool stopped = false;

    public GameObject UI;
    

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (stopped)
            {
                continu ();
            }
            else
            {
                stop ();
            }
        }
    }

    public void continu ()
    {
        UI.SetActive(false);
        Time.timeScale = 1f;
        stopped = false;
    }

    void stop ()
    {
        UI.SetActive(true);
        Time.timeScale = 0f;
        stopped = true;
    }

    public void open_Option ()
    {

    }

    public void Quit_Game ()
    {

    }
}
