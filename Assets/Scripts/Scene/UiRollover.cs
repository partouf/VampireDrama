﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UiRollover : MonoBehaviour
{
    public void RolloverPlayerStats()
    {
        public Text transitionTxt;
        public float animationTime = 1.5f; 

        public float desiredNr, initialNr, currentNr;

        public void setNr(float value)
        {
            initialNr = currentNr;
            desiredNr = value;
        } 
        public void addToNr(float value) 
        {
            initialNr = currentNr;
            desiredNr += value;
        }
        public void UpdateNr()
        {
            if(currentNr !=desiredNr)
            {
                if(initialNr < desiredNr)
                {
                    currentNr += (animationTime * Time.deltaTime) * (desiredNr - initialNr);
                }
            }
            else
            {
                currentNr -= (animationTime * Time.deltaTime) * (initialNr - desiredNr);
                if(currentNr <= desiredNr)
                  currentNr = desiredNr;  
            }
             
            transitionTxt.text = currentNr.ToString();
        }
    }
}
