using UI;
using UnityEngine;

namespace Healths
{
    public class PlayerHealth : Health
    {
        private Animator AnimatorComp => GetComponent<Animator>();
        private HealthBar HealthBar => FindObjectOfType<HealthBar>();
        [HideInInspector] public bool canBeDamaged = true;
        private readonly int _hitTrigger = Animator.StringToHash("HitTrigger");
        private readonly int _deathTrigger = Animator.StringToHash("DeathTrigger");

        public override void Damage(int amount)
        {
            if (!canBeDamaged) return;
            base.Damage(amount);
            HealthBar.UpdateVal(healthValue);
            AnimatorComp.SetTrigger(_hitTrigger);
        }

        public void GainHealth(int amount)
        {
            healthValue += amount;
            if (healthValue > maxHealth) healthValue = maxHealth;
            HealthBar.UpdateVal(healthValue);
        }

        protected override void Death()
        {
            AnimatorComp.SetTrigger(_deathTrigger);
        }
    }
}
