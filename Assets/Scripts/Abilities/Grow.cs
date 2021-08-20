using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    private Shoot shoot => GetComponent<Shoot>();
    
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
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Ready)
        {
            TriggerGrowth();
        }
    }

    void TriggerGrowth()
    {
        damageOnContact.contactDamage = 40;
        
        shoot.available = false;
        
        growing = true;
        Invoke(nameof(StopGrowing), growTime);

        Ready = false;
        Invoke(nameof(SetReady), delay);
            
        abilitySlot.TriggerCoolDown(delay);
    }

    void StopGrowing()
    {
        growing = false;
        Invoke(nameof(SetShrink), duration);
    }

    void SetShrink()
    {
        shrink = true;
        damageOnContact.contactDamage = 5;
        shoot.available = true;
    }

    void SetReady()
    {
        Ready = true;
    }
}
