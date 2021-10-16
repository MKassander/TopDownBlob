using System.Collections;
using Damage;
using UnityEngine;

namespace Abilities.Ult
{
    public class DefaultUltimateAbility : UltimateAbility
    {
        [SerializeField] private float growSpeed, growTime, duration;
        private DamageOnContact DamageOnContact => GetComponent<DamageOnContact>();
        private bool _growing, _shrink;

        private void FixedUpdate()
        {
            if (_growing) transform.localScale += new Vector3(1, 1, 1) * (Time.deltaTime * growSpeed);
            if (_shrink)
            {
                transform.localScale -= new Vector3(1, 1, 1) * (Time.deltaTime * growSpeed);
                if (transform.localScale.x <= 2) _shrink = false;
            }
        }

        private IEnumerator StopGrowing()
        {
            yield return new WaitForSeconds(growTime);
            _growing = false;
            StartCoroutine(SetShrink());
        }

        private IEnumerator SetShrink()
        {
            yield return new WaitForSeconds(duration);
            _shrink = true;
            DamageOnContact.contactDamage = 5;
            ShootAbility.available = true;
            PlayerHealth.canBeDamaged = true;
        }

        public override void Trigger()
        {
            if (!ready) return;
            DamageOnContact.contactDamage = 40;
            ShootAbility.available = false;
            PlayerHealth.canBeDamaged = false;
        
            _growing = true;
            StartCoroutine(StopGrowing());

            base.Trigger();
        }
    }
}
