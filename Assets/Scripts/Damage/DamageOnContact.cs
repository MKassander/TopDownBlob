using Healths;
using UnityEngine;

namespace Damage
{
    public abstract class DamageOnContact : MonoBehaviour
    {
        public int contactDamage;
    
        private void OnCollisionEnter(Collision other)
        {
            CollisionFunction(other);
        }

        protected virtual void CollisionFunction(Collision other)
        {
            other.gameObject.GetComponent<Health>().Damage(contactDamage);
        }
    }
}
