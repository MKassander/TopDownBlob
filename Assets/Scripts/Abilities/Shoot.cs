
using UnityEngine;

public class Shoot : MonoBehaviour, IAbility
{
    [HideInInspector]public GameObject projectile;
    private Animator animator => GetComponent<Animator>();
    public Transform spawnPoint;
    private bool Ready = true;
    public int delay;
    public bool available = true;

    public AbilitySlot abilitySlot;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Ready && available) Trigger();
    }

    void SetReady()
    {
        Ready = true;
    }

    public void Trigger()
    {
        var proj = Instantiate(projectile);
        proj.transform.position = spawnPoint.position;
        proj.transform.rotation = spawnPoint.rotation;

        Ready = false;
        animator.SetTrigger("AttackTrigger");
        
        abilitySlot.TriggerCoolDown(delay);
        
        Invoke(nameof(SetReady), delay);
    }
}
