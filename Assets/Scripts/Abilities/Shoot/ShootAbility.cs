
using UnityEngine;

public class ShootAbility : MonoBehaviour, Itrigger
{
    [SerializeField] private GameObject projectile;
    private Animator animator => GetComponent<Animator>();
    public Transform spawnPoint;
    private bool Ready = true;
    public int delay;
    public bool available = true;

    public AbilitySlot abilitySlot;

    void SetReady()
    {
        Ready = true;
    }

    public void Trigger()
    {
        if (!Ready || !available) return;
        var proj = Instantiate(projectile);
        proj.transform.position = spawnPoint.position;
        proj.transform.rotation = spawnPoint.rotation;

        Ready = false;
        animator.SetTrigger("AttackTrigger");
        
        abilitySlot.TriggerCoolDown(delay);
        
        Invoke(nameof(SetReady), delay);
    }
}
