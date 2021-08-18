using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody Rigidbody => GetComponent<Rigidbody>();

    public float speed;

    void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical"));
        Rigidbody.MovePosition(transform.position + input * (Time.deltaTime * speed));
    }
}
