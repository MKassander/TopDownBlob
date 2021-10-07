using Healths;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    public int contactDamage;
    [SerializeField]private bool player, enemy;
    private void OnCollisionEnter(Collision other)
    {
        if (enemy)
        {
            if (!other.gameObject.CompareTag("Player")) return;
            other.gameObject.GetComponent<Health>().Damage(contactDamage);
            Destroy(gameObject);
        }
        else
        {
            if (!other.gameObject.CompareTag("Damageable")) return;
            other.gameObject.GetComponent<Health>().Damage(contactDamage);
            if (!player) Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (enemy)
        {
            Destroy(gameObject);
        }
    }
    //Todo: clean up
}
