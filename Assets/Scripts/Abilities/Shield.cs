using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shield;
    public AbilitySlot abilitySlot;
    public float delay;
    public float shieldLength;
    private bool Ready = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && Ready)
        {
            shield.SetActive(true);
            Ready = false;
            
            abilitySlot.TriggerCoolDown(delay);
            
            Invoke(nameof(DisableShield), shieldLength);
            
            Invoke(nameof(SetReady), delay);
        }
    }

    void DisableShield()
    {
        shield.SetActive(false);
    }

    void SetReady()
    {
        Ready = true;
    }
}
