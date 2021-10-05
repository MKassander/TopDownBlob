using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateAbility : MonoBehaviour, Itrigger
{
    private ShootAbility ShootAbility => GetComponent<ShootAbility>();
    
    public float growSpeed, growTime, duration;
    private bool growing, shrink;
    private bool Ready = true;
    public float delay;
    
    public AbilitySlot abilitySlot;
    public DamageOnContact damageOnContact;

    private void FixedUpdate()
    {
        if (growing) transform.localScale += new Vector3(1, 1, 1) * (Time.deltaTime * growSpeed);
        if (shrink)
        {
            transform.localScale -= new Vector3(1, 1, 1) * (Time.deltaTime * growSpeed);
            if (transform.localScale.x <= 2) shrink = false;
        }
    }

    private void StopGrowing()
    {
        growing = false;
        Invoke(nameof(SetShrink), duration);
    }

    private void SetShrink()
    {
        shrink = true;
        damageOnContact.contactDamage = 5;
        ShootAbility.available = true;
    }

    private void SetReady()
    {
        Ready = true;
    }

    public void Trigger()
    {
        damageOnContact.contactDamage = 40;
        
        ShootAbility.available = false;
        
        growing = true;
        Invoke(nameof(StopGrowing), growTime);

        Ready = false;
        Invoke(nameof(SetReady), delay);
            
        abilitySlot.TriggerCoolDown(delay);
    }
}
