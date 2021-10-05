using System.Collections;
using Abilities.Shoot;
using Healths;
using UI;
using UnityEngine;

namespace Abilities.Ult
{
    public abstract class UltimateAbility : MonoBehaviour, ITrigger
    {
        protected ShootAbility ShootAbility => GetComponent<ShootAbility>();
        protected PlayerHealth PlayerHealth => GetComponent<PlayerHealth>();
        protected bool ready = true;
        [SerializeField] private float delay;
    
        [SerializeField] private AbilitySlot abilitySlot;

        private IEnumerator SetReady()
        {
            yield return new WaitForSeconds(delay);
            ready = true;
        }

        public virtual void Trigger()
        {
            ready = false;
            StartCoroutine(SetReady());

            abilitySlot.TriggerCoolDown(delay);
        }
    }
}
