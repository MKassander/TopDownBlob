
using System;
using UnityEngine;

public class ShootAbility : MonoBehaviour, Itrigger
{
    [SerializeField] private SO_Projectile projectile;
    private Animator animator => GetComponent<Animator>();
    public Transform spawnPoint;
    private bool Ready = true;
    public bool available = true;

    public AbilitySlot abilitySlot;

    void SetReady()
    {
        Ready = true;
    }

    public void Trigger()
    {
        if (!Ready || !available) return;
        var proj = Instantiate(projectile.prefab);
        proj.transform.position = spawnPoint.position;
        proj.transform.rotation = spawnPoint.rotation;

        proj.GetComponent<DamageOnContact>().contactDamage = projectile.damage;

        Ready = false;
        animator.SetTrigger("AttackTrigger");
        
        abilitySlot.TriggerCoolDown(projectile.delay);
        
        Invoke(nameof(SetReady), projectile.delay);
    }
}
