using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerE : MonoBehaviour {

    #region Singelton

    public static PlayerE instance;
    
    void Awake ()
    {
        instance = this;
    }

    #endregion

    public GameObject Player;
}
