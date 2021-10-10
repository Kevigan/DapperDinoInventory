using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour, IDamageable, IHealable
{
    [SerializeField] private int maxHealth = 100;
    private int currentHealth = 0;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void DealDamage(int amount)
    {
        if (amount <= 0) return;

        currentHealth = Mathf.Max(0, currentHealth - amount); // if health goes under zero, it will return 0

        if(currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(int amount)
    {
        if (amount <= 0) return;

        currentHealth = Mathf.Min(maxHealth, currentHealth + amount);
    }

    
}
