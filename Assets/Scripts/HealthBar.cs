using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public static float health = 1.0f;

 //   void Start()
 //   {
 //       GameObject Player = GameObject.Find("Player");
 //       Controller playerScript = GetComponent<Controller>();
 //       Controller.death = false;
 //   }



    void Update () {

        Image image = GetComponent<Image>();
        image.fillAmount = health;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            health -= 0.1f;
        }

        if (health < 0.0f)
        {
            health = 0.0f;
        }

        if(health == 0.0f)
        {
            Controller.death = true;
            health = 1.0f;
        }

    }
}
