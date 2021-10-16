using UnityEngine;

namespace Damage
{
    public class EnemyDamageOnContact : DamageOnContact
    {
        protected override void CollisionFunction(Collision other)
        {
            if (!other.gameObject.CompareTag("Player")) return;
            base.CollisionFunction(other);
            Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
        }
    }
}
