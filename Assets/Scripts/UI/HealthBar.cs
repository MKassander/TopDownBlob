using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Slider Slider => GetComponent<Slider>();
    public static HealthBar instance;

    private void Start()
    {
        instance = this;
    }

    public void UpdateVal(int val)
    {
        Slider.value = val;
    }
}
