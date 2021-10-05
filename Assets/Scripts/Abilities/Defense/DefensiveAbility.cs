using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensiveAbility : MonoBehaviour, Itrigger
{
    [SerializeField] private SO_Defensive shield;
    private ShootAbility ShootAbility => GetComponent<ShootAbility>();
    public AbilitySlot abilitySlot;
    private bool Ready = true;
    private GameObject shieldGo;
    [SerializeField] private Transform prefabParent;

    void DisableShield()
    {
        Destroy(shieldGo.gameObject);
        ShootAbility.available = true;
    }

    void SetReady()
    {
        Ready = true;
    }

    public void Trigger()
    {
        if (!Ready) return;
        var go = Instantiate(shield.prefab, prefabParent);
        shieldGo = go;
        
        Ready = false;
        ShootAbility.available = false;
            
        abilitySlot.TriggerCoolDown(shield.delay);
            
        Invoke(nameof(DisableShield), shield.duration);
            
        Invoke(nameof(SetReady), shield.delay);
    }
}
