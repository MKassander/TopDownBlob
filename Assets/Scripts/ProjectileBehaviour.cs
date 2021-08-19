using System;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    Rigidbody rigidBody => GetComponent<Rigidbody>();
    public float speed;
    public int destroyAfter;
    private Vector3 Direction = new Vector3(0, 0, 1);
    

    private void Start()
    {
        Invoke(nameof(DestroyThis), destroyAfter);
    }

    void FixedUpdate()
    {
        rigidBody.MovePosition(transform.position + transform.TransformDirection(Direction) * (Time.deltaTime * speed));
    }

    void DestroyThis()
    {
        Destroy(gameObject);
    }
}
