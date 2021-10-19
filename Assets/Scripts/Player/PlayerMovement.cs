using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody Rigidbody => GetComponent<Rigidbody>();
        private Vector2 _mousePos;
        [SerializeField] private float speed;

        private void FixedUpdate()
        {
            var input = new Vector3(Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical"));
            Rigidbody.MovePosition(transform.position + input.normalized * (Time.deltaTime * speed));

            var cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            var ground = new Plane(Vector3.up, Vector3.zero);

            if (ground.Raycast(cameraRay, out var rayLength))
            {
                Vector3 pointToLook = cameraRay.GetPoint(rayLength);
                transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
            }
        }
    }
}
