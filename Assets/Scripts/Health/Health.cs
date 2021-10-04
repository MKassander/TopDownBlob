
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    protected int HealthValue { get; private set; }
    [SerializeField]private int MaxHealth;

    private void Start()
    {
        HealthValue = MaxHealth;
    }
    public virtual void Damage(int amount)
    {
        HealthValue -= amount;
        if (HealthValue <= 0) Death();
    }

    protected virtual void Death(){}
}
