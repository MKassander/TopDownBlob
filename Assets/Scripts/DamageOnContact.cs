using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    public int contactDamage;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Damageable"))
        {
            other.gameObject.GetComponent<Health>().Damage(contactDamage);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
