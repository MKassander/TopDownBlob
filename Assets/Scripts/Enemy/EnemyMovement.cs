using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Detection Detection => GetComponent<Detection>();
    private Rigidbody Rigidbody => GetComponent<Rigidbody>();
    [SerializeField] private int speed;


    private void FixedUpdate()
    {
        if (!Detection.playerInRange) return;
        transform.LookAt(Detection.player);
        Rigidbody.MovePosition(transform.position + transform.TransformDirection(Vector3.forward) * (Time.deltaTime * speed));
    }
}
