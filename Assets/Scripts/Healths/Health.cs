
using UnityEngine;

namespace Healths
{
    public abstract class Health : MonoBehaviour
    {
        protected int healthValue;
        [SerializeField]private int maxHealth;

        private void Start()
        {
            healthValue = maxHealth;
        }
        public virtual void Damage(int amount)
        {
            healthValue -= amount;
            print(healthValue);
            if (healthValue <= 0) Death();
        }

        protected virtual void Death(){}
    }
}
