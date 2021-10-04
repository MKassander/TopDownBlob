using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensiveAbility : MonoBehaviour, Itrigger
{
    private ShootAbility ShootAbility => GetComponent<ShootAbility>();
    public GameObject shield;
    public AbilitySlot abilitySlot;
    public float delay;
    public float shieldLength;
    private bool Ready = true;

    void DisableShield()
    {
        shield.SetActive(false);
        ShootAbility.available = true;
    }

    void SetReady()
    {
        Ready = true;
    }

    public void Trigger()
    {
        if (!Ready) return;
        shield.SetActive(true);
        Ready = false;
        ShootAbility.available = false;
            
        abilitySlot.TriggerCoolDown(delay);
            
        Invoke(nameof(DisableShield), shieldLength);
            
        Invoke(nameof(SetReady), delay);
    }
}
