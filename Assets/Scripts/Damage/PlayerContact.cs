using UnityEngine;

namespace Damage
{
    public class PlayerContact : DamageOnContactBase
    {
        protected override void CollisionFunction(Collision other)
        {
            if (!other.gameObject.CompareTag("Damageable")) return;
            base.CollisionFunction(other);
        }
    }
}
