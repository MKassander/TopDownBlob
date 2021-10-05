using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAbility : MonoBehaviour, Itrigger
{
    [SerializeField] private AbilitySlot abilitySlot;
    [SerializeField] private SO_Movement movementSo;

    private bool Ready = true;

    IEnumerator SetReady()
    {
        yield return new WaitForSeconds(movementSo.delay);
        Ready = true;
    }

    public void Trigger()
    {
        if (!Ready) return;
        Vector3 newPosition = transform.position + transform.TransformDirection (new Vector3(0,0,movementSo.leap));
        transform.position = newPosition;

        Ready = false;
            
        abilitySlot.TriggerCoolDown(movementSo.delay);

        StartCoroutine(SetReady());
    }
}
