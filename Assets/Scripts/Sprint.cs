using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
    public AbilitySlot abilitySlot;

    public float leap;
    public float delay;
    private bool Ready = true;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && Ready)
        {
            Vector3 newPosition = transform.position + transform.TransformDirection (new Vector3(0,0,leap));
            transform.position = newPosition;

            Ready = false;
            
            abilitySlot.TriggerCoolDown(delay);
        
            Invoke(nameof(SetReady), delay);
        }
    }
    
    void SetReady()
    {
        Ready = true;
    }
}
