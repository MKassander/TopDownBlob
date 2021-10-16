using UnityEngine;

namespace Damage
{
    public class PlayerDamageOnContact : DamageOnContact
    {
        protected override void CollisionFunction(Collision other)
        {
            if (!other.gameObject.CompareTag("Damageable")) return;
            base.CollisionFunction(other);
        }
    }
}
