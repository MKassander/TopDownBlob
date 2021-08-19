using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShootAbility : MonoBehaviour
{
    private Shoot shoot => GetComponent<Shoot>();

    public GameObject projectile;

    private void Start()
    {
        Assign();
    }

    public void Shoot()
    {
        shoot.Fire();
    }

    public void Assign()
    {
        shoot.projectile = projectile;
    }
}
