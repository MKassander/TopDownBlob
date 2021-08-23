using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody rigidbody => GetComponent<Rigidbody>();
    readonly Vector3 Direction = new Vector3(0, 0, 1);
    [SerializeField] private int speed;
    [SerializeField] private Transform player;

    [HideInInspector]public bool PlayerInRange;
    private void FixedUpdate()
    {
        if (PlayerInRange)
        {
            transform.LookAt(player);
            rigidbody.MovePosition(transform.position + transform.TransformDirection(Direction) * (Time.deltaTime * speed));
        }
    }
}
