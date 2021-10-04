using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    private Animator AnimatorComp => GetComponent<Animator>();
    public override void Damage(int amount)
    {
        base.Damage(amount);
        AnimatorComp.SetTrigger("HitTrigger");
    }

    protected override void Death()
    {
        Progress.instance.AddProgress();
        Destroy(gameObject);
    }
}
