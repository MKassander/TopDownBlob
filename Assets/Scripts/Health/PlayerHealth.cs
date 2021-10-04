using UnityEngine;

public class PlayerHealth : Health
{
    private Animator AnimatorComp => GetComponent<Animator>();
    private bool Dead;
    public override void Damage(int amount)
    {
        base.Damage(amount);
        HealthBar.instance.UpdateVal();
        AnimatorComp.SetTrigger("HitTrigger");
    }

    protected override void Death()
    {
        AnimatorComp.SetTrigger("DeathTrigger");
        Dead = true;
    }
}
