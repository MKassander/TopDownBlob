using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Slider slider => GetComponent<Slider>();
    public Health health;
    public static HealthBar instance;

    private void Start()
    {
        instance = this;
    }

    public void Update()
    {
        slider.value = health.health;
    }
}
