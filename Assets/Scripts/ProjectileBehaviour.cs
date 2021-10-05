using System;
using System.Collections;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    private Rigidbody RigidBody => GetComponent<Rigidbody>();
    public float speed;
    public int destroyAfter;
    

    private void Start()
    {
        StartCoroutine(DestroyThis());
    }

    void FixedUpdate()
    {
        RigidBody.MovePosition(transform.position + transform.TransformDirection(Vector3.forward) * (Time.deltaTime * speed));
    }

    IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(destroyAfter);
        Destroy(gameObject);
    }
}
