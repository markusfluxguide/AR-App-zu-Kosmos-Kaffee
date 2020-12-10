﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStartController : MonoBehaviour
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
        gameObject.GetComponent<Animator>().SetBool("show", true);
    }

    void OnHideAnimationDone() {
        gameObject.GetComponent<CanvasGroup>().alpha = 0;
        gameObject.SetActive(false);
    } 
}