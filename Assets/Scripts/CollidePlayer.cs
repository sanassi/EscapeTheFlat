using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePlayer : MonoBehaviour
{
    public Hero hero;

    public int healthPoints = 200;

    public HealthBar healthBar;

    private void OnTriggerEnter(Collider other)
    {
        if (hero.maxHealth - hero.currentHealth > 250)
        {
            hero.currentHealth += healthPoints;
        }
        else
        {
            hero.currentHealth += (hero.maxHealth - hero.currentHealth);
        }
        healthBar.SetHealth(hero.currentHealth);
        Destroy(gameObject);
    }
}
