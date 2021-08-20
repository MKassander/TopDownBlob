
using UnityEngine;

public class Health : MonoBehaviour
{
    private Animator animator => GetComponent<Animator>();
    public int health;
    public int maxHealth;
    public bool player;
    public bool dead;

    private void Start()
    {
        health = maxHealth;
    }
    
    public void Damage(int amount)
    {
        health -= amount;
        if (player)HealthBar.instance.Update();
        if (health <= 0) Death();
        if (animator != null) animator.SetTrigger("HitTrigger");
    }

    void Death()
    {
        if (animator != null)
        {
            animator.SetTrigger("DeathTrigger");
            dead = true;
        }
        else Destroy(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && player)
        {
            Damage(10);
        }
    }
}
