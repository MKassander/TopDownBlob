using UnityEngine;

namespace Healths
{
    public class EnemyHealth : Health
    {
        private static readonly int HitTrigger = Animator.StringToHash("HitTrigger");
        private Animator AnimatorComp => GetComponent<Animator>();
        public override void Damage(int amount)
        {
            base.Damage(amount);
            AnimatorComp.SetTrigger(HitTrigger);
        }

        protected override void Death()
        {
            Progress.instance.AddProgress();
            Destroy(gameObject);
        }
    }
}
