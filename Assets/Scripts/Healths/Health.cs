
using UnityEngine;

namespace Healths
{
    public abstract class Health : MonoBehaviour
    {
        [SerializeField]protected int maxHealth;
        protected int healthValue;

        private void Start()
        {
            healthValue = maxHealth;
        }
        public virtual void Damage(int amount)
        {
            healthValue -= amount;
            if (healthValue <= 0) Death();
        }

        protected virtual void Death(){}
    }
}
