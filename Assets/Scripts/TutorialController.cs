﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{

    public bool wasShown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnEnable() {
        wasShown = true;
    }

    void OnDisable() {

    }
    
    void OnHideAnimationDone() {
        return;
    } 
}
