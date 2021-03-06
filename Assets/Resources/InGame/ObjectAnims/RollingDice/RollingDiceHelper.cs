﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingDiceHelper : MonoBehaviour
{
    private Animator controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<Animator>();
        SetResult(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetResult(int resultVal) {
        if (resultVal >= 1 && resultVal <= 6) {
            if (controller) {
                controller.SetInteger("Result", resultVal);
            }
        }
    }

    public void Reset()
    {
        if (controller)
        {
            //Do reset the value to 0 for looping the rolling animation
            controller.SetInteger("Result", 0);

            //Trigger Looping animation
            controller.SetTrigger("StartAnima");
        }
    }

    
}
