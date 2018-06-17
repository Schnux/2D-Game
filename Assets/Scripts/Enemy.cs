using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collidedObject)
    {
        switch (collidedObject.tag)
        {
            case "Player":
                HealthBar.health -= 0.1f;

                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
