using UnityEngine;

namespace Healths
{
    public class PlayerHealth : Health
    {
        private Animator AnimatorComp => GetComponent<Animator>();
        private bool Dead;
        [HideInInspector] public bool canBeDamaged = true;
        private static readonly int HitTrigger = Animator.StringToHash("HitTrigger");
        private static readonly int DeathTrigger = Animator.StringToHash("DeathTrigger");

        public override void Damage(int amount)
        {
            if (!canBeDamaged) return;
            base.Damage(amount);
            HealthBar.instance.UpdateVal(healthValue);
            AnimatorComp.SetTrigger(HitTrigger);
        }

        protected override void Death()
        {
            AnimatorComp.SetTrigger(DeathTrigger);
            Dead = true;
        }
    }
}
