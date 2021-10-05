using Abilities.Move;
using Abilities.Shoot;
using Abilities.Ult;
using UnityEngine;

namespace Abilities
{
    public class AbilityManager : MonoBehaviour
    {
        private ShootAbility ShootAbility => GetComponent<ShootAbility>();
        private MovementAbility MovementAbility => GetComponent<MovementAbility>();
        private DefensiveAbility DefensiveAbility => GetComponent<DefensiveAbility>();
        private UltimateAbility UltimateAbility => GetComponent<UltimateAbility>();

        [SerializeField] private KeyCode shootKey, movementKey, defenseKey, ultKey;

        private void Update()
        {
            if (Input.GetKeyDown(shootKey)) ShootAbility.Trigger();
            if (Input.GetKeyDown(movementKey)) MovementAbility.Trigger();
            if (Input.GetKeyDown(defenseKey)) DefensiveAbility.Trigger();
            if (Input.GetKeyDown(ultKey)) UltimateAbility.Trigger();
        }
    }
}
