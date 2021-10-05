using System.Collections;
using UnityEngine;

public class DefaultUltimateAbility : UltimateAbility
{
    [SerializeField] private float growSpeed, growTime, duration;
    private bool growing, shrink;

    private DamageOnContact DamageOnContact => GetComponent<DamageOnContact>();

    private void FixedUpdate()
    {
        if (growing) transform.localScale += new Vector3(1, 1, 1) * (Time.deltaTime * growSpeed);
        if (shrink)
        {
            transform.localScale -= new Vector3(1, 1, 1) * (Time.deltaTime * growSpeed);
            if (transform.localScale.x <= 2) shrink = false;
        }
    }

    IEnumerator StopGrowing()
    {
        yield return new WaitForSeconds(growTime);
        growing = false;
        StartCoroutine(SetShrink());
    }

    IEnumerator SetShrink()
    {
        yield return new WaitForSeconds(duration);
        shrink = true;
        DamageOnContact.contactDamage = 5;
        ShootAbility.available = true;
    }

    public override void Trigger()
    {
        DamageOnContact.contactDamage = 40;
        
        ShootAbility.available = false;
        
        growing = true;
        StartCoroutine(StopGrowing());

        base.Trigger();
    }
}
