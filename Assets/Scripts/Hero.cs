using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public int maxStamina;
    public int currentStamina;

    private bool _isAlive;

    public HealthBar healthBar;

    public GameManager gameManager;
    public staminaBar staminaBar;
    // Start is called before the first frame update
    void Start()
    {
        _isAlive = true;
        
        maxHealth = 1000;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        maxStamina = 500;
        currentStamina = maxHealth;
        staminaBar.SetMaxStamina(maxStamina);
    }

    public bool IsAlive
    {
        get => _isAlive;
        set => _isAlive = value;
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth <= 0)
        {
            gameManager.EndGame();
        }
        if (currentHealth > 0)
        {
            currentHealth -= damage;
        }
        healthBar.SetHealth(currentHealth);
    }

    public void LooseStamina(int stamina)
    {
        if (currentHealth > 0)
        {
            currentStamina -= stamina;
        }
        
        staminaBar.SetStamina(currentStamina);
    }

    public void UpdateStamina()
    {
        if (currentStamina < maxStamina)
        {
            currentStamina += 1;
        }
        staminaBar.SetStamina(currentStamina);
    }
    
}
