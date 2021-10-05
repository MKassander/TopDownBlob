using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UltimateAbility : MonoBehaviour, Itrigger
{
    protected ShootAbility ShootAbility => GetComponent<ShootAbility>();

    private bool Ready = true;
    [SerializeField] private float delay;
    
    [SerializeField] private AbilitySlot abilitySlot;

    IEnumerator SetReady()
    {
        yield return new WaitForSeconds(delay);
        Ready = true;
    }

    public virtual void Trigger()
    {
        Ready = false;
        StartCoroutine(SetReady());

        abilitySlot.TriggerCoolDown(delay);
    }
}
