using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    private EnemyMovement EnemyMovement => GetComponent<EnemyMovement>();
    [SerializeField] private Transform player;
    [SerializeField] private float distanceThreshold;

    private void FixedUpdate()
    {
        var distance = Vector3.Distance(transform.position, player.position);
        if (distance <= distanceThreshold) EnemyMovement.PlayerInRange = true;
        else EnemyMovement.PlayerInRange = false;
    }
}
