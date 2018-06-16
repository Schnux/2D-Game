using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public float health = 1.0f;
    

    


	void Update () {

        Image image = GetComponent<Image>();
        image.fillAmount = health;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            health = 0.6f;
        }
    }
}
