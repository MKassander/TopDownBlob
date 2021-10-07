using System.Collections;
using UnityEngine;

namespace Abilities.Shoot
{
    public class ProjectileBehaviour : MonoBehaviour
    {
        private Rigidbody RigidBody => GetComponent<Rigidbody>();
        public float speed;
        public int destroyAfter;
    

        private void Start()
        {
            StartCoroutine(DestroyThis());
        }

        private void FixedUpdate()
        {
            RigidBody.MovePosition(transform.position + transform.TransformDirection(Vector3.forward) * (Time.deltaTime * speed));
        }

        private IEnumerator DestroyThis()
        {
            yield return new WaitForSeconds(destroyAfter);
            Destroy(gameObject);
        }
    }
}
