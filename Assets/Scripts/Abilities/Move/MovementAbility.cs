using System.Collections;
using UI;
using UnityEngine;

namespace Abilities.Move
{
    public class MovementAbility : MonoBehaviour, ITrigger
    {
        [SerializeField] private AbilitySlot abilitySlot;
        [SerializeField] private SoMovement movementSo;

        private bool _ready = true;

        private IEnumerator SetReady()
        {
            yield return new WaitForSeconds(movementSo.delay);
            _ready = true;
        }

        public void Trigger()
        {
            if (!_ready) return;
            var newPosition = transform.position + transform.TransformDirection (new Vector3(0,0,movementSo.leap));
            transform.position = newPosition;

            _ready = false;
            
            abilitySlot.TriggerCoolDown(movementSo.delay);

            StartCoroutine(SetReady());
        }
    }
}
