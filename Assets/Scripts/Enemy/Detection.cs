using Healths;
using UnityEngine;

namespace Enemy
{
    public class Detection : MonoBehaviour
    {
        [SerializeField] private float distanceThreshold;
        [HideInInspector]public bool playerInRange;
        [HideInInspector]public Transform player;

        private void Start()
        {
            player = FindObjectOfType<PlayerHealth>().gameObject.transform;
        }

        private void FixedUpdate()
        {
            var distance = Vector3.Distance(transform.position, player.position);
            playerInRange = distance <= distanceThreshold;
        }
    }
}
