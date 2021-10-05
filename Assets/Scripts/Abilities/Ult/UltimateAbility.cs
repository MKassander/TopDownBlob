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

    IEnumerator StopGrowing()
    {
        yield return new WaitForSeconds(growTime);
        growing = false;
        StartCoroutine(SetShrink());
    }

    IEnumerator SetShrink()
    {
        yield return new WaitForSeconds(duration);
        shrink = true;
        damageOnContact.contactDamage = 5;
        ShootAbility.available = true;
    }

    IEnumerator SetReady()
    {
        yield return new WaitForSeconds(delay);
        Ready = true;
    }

    public void Trigger()
    {
        damageOnContact.contactDamage = 40;
        
        ShootAbility.available = false;
        
        growing = true;
        StartCoroutine(StopGrowing());

        Ready = false;
        StartCoroutine(SetReady());

        abilitySlot.TriggerCoolDown(delay);
    }
}
