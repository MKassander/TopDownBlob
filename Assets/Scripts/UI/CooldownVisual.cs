using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownVisual : MonoBehaviour
{
    private Slider slider => GetComponentInChildren<Slider>();

    private float Timer;

    public void TriggerCoolDown(float time)
    {
        slider.maxValue = time;
        Timer = time;
    }

    private void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
            slider.value = Timer;
        }
    }
}
