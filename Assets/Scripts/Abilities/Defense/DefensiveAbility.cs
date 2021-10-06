using System.Collections;
using Abilities;
using Abilities.Shoot;
using UI;
using UnityEngine;

public class DefensiveAbility : MonoBehaviour, ITrigger
{
    [SerializeField] private SoDefensive shield;
    private ShootAbility ShootAbility => GetComponent<ShootAbility>();
    [SerializeField] private AbilitySlot abilitySlot;
    private bool _ready = true;
    private GameObject _shieldGo;
    [SerializeField] private Transform prefabParent;

    private IEnumerator DisableShield()
    {
        yield return new WaitForSeconds(shield.duration);
        Destroy(_shieldGo.gameObject);
        ShootAbility.available = true;
    }

    private IEnumerator SetReady()
    {
        yield return new WaitForSeconds(shield.delay);
        _ready = true;
    }

    public void Trigger()
    {
        if (!_ready) return;
        var go = Instantiate(shield.prefab, prefabParent);
        _shieldGo = go;
        
        _ready = false;
        ShootAbility.available = false;
            
        abilitySlot.TriggerCoolDown(shield.delay);

        StartCoroutine(DisableShield());
        StartCoroutine(SetReady());
    }
}
