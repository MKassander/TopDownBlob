using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAbility : MonoBehaviour, Itrigger
{
    public AbilitySlot abilitySlot;

    public float leap;
    public float delay;
    private bool Ready = true;

    void SetReady()
    {
        Ready = true;
    }

    public void Trigger()
    {
        if (!Ready) return;
        Vector3 newPosition = transform.position + transform.TransformDirection (new Vector3(0,0,leap));
        transform.position = newPosition;

        Ready = false;
            
        abilitySlot.TriggerCoolDown(delay);
        
        Invoke(nameof(SetReady), delay);
    }
}
