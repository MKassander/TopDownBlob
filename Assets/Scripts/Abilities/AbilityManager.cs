using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    private ShootAbility ShootAbility => GetComponent<ShootAbility>();
    private MovementAbility MovementAbility => GetComponent<MovementAbility>();
    private DefensiveAbility DefensiveAbility => GetComponent<DefensiveAbility>();
    private UltimateAbility UltimateAbility => GetComponent<UltimateAbility>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) ShootAbility.Trigger();
        if (Input.GetKeyDown(KeyCode.LeftShift)) MovementAbility.Trigger();
        if (Input.GetKeyDown(KeyCode.Mouse1)) DefensiveAbility.Trigger();
        if (Input.GetKeyDown(KeyCode.Space)) UltimateAbility.Trigger();
    }
}
