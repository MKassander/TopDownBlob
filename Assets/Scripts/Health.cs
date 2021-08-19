using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;

    private void Start()
    {
        health = maxHealth;
    }
    
    public void Damage(int amount)
    {
        health -= amount;
        if (health <= 0) Death();
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
