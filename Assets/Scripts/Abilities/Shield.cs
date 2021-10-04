using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour, IAbility
{
    private Shoot shoot => GetComponent<Shoot>();
    public GameObject shield;
    public AbilitySlot abilitySlot;
    public float delay;
    public float shieldLength;
    private bool Ready = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && Ready) Trigger();
    }

    void DisableShield()
    {
        shield.SetActive(false);
        shoot.available = true;
    }

    void SetReady()
    {
        Ready = true;
    }

    public void Trigger()
    {
        shield.SetActive(true);
        Ready = false;
        shoot.available = false;
            
        abilitySlot.TriggerCoolDown(delay);
            
        Invoke(nameof(DisableShield), shieldLength);
            
        Invoke(nameof(SetReady), delay);
    }
}
