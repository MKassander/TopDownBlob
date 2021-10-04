using UnityEngine;

public class BasicShootAbility : MonoBehaviour
{
    private Shoot shoot => GetComponent<Shoot>();

    public GameObject projectile;

    private void Start()
    {
        Assign();
    }

    public void Shoot()
    {
        shoot.Trigger();
    }

    public void Assign()
    {
        shoot.projectile = projectile;
    }
}
