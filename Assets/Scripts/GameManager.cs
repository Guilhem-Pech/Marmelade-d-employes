﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool bersekModActivated = false;
    public static GameManager instance;
    public Killable[] killable;
    
    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;//Avoid doing anything else
        }
 
        instance = this;
        DontDestroyOnLoad( this.gameObject );
    }

    void setBerserkMode()
    {
        foreach (Killable obj in killable)
        {
            obj.SetOutline();
        }

        bersekModActivated = true;
    }
    
}