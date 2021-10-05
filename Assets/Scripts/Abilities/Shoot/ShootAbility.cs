using System.Collections;
using UI;
using UnityEngine;

namespace Abilities.Shoot
{
    public class ShootAbility : MonoBehaviour, ITrigger
    {
        [SerializeField] private SoProjectile projectile;
        private Animator Animator => GetComponent<Animator>();
        public Transform spawnPoint;
        private bool _ready = true;
        public bool available = true;

        public AbilitySlot abilitySlot;
        private static readonly int AttackTrigger = Animator.StringToHash("AttackTrigger");

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

            proj.GetComponent<DamageOnContact>().contactDamage = projectile.damage;

            _ready = false;
            Animator.SetTrigger(AttackTrigger);
        
            abilitySlot.TriggerCoolDown(projectile.delay);

            StartCoroutine(SetReady());
        }
    }
}
