using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public static Progress instance;

    private int Level = 1;
    private int CurrentProgress;
    public int xpAmount;
    private Slider ProgressSlider => GetComponent<Slider>();

    private void Start()
    {
        instance = this;
    }

    public void AddProgress()
    {
        CurrentProgress += xpAmount;
        ProgressSlider.value = CurrentProgress;
        if (CurrentProgress >= ProgressSlider.maxValue)
        {
            Level++;
            Debug.Log("Level " + Level);
            ProgressSlider.value = ProgressSlider.minValue;
            CurrentProgress = (int)ProgressSlider.minValue;
            //Upgrade or whatev
        }
    }
}
