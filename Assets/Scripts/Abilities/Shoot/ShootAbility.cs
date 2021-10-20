using System.Collections;
using Damage;
using UI;
using UnityEngine;

namespace Abilities.Shoot
{
    public class ShootAbility : MonoBehaviour, ITrigger
    {
        [SerializeField] private SoProjectile projectile;
        private Animator Animator => GetComponent<Animator>();
        [SerializeField] private AbilitySlot abilitySlot;
        [SerializeField] private Transform spawnPoint;
        
        private bool _ready = true;
        [HideInInspector]public bool available = true;
        private readonly int _attackTrigger = Animator.StringToHash("AttackTrigger");

        private IEnumerator SetReady()
        {
            yield return new WaitForSeconds(projectile.delay);
            _ready = true;
        }

        public void Trigger()
        {
            if (!_ready || !available) return;
            var proj = Instantiate(projectile.prefab);
            proj.transform.position = spawnPoint.position;
            proj.transform.rotation = spawnPoint.rotation;

            proj.GetComponent<DamageOnContactBase>().contactDamage = projectile.damage;

            _ready = false;
            Animator.SetTrigger(_attackTrigger);
        
            abilitySlot.TriggerCoolDown(projectile.delay);

            StartCoroutine(SetReady());
        }
    }
}
