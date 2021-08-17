using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Hero hero;
    public GameObject[] fires; 

    private void Start()
    {
        fires = GameObject.FindGameObjectsWithTag("Fire"); // search location of all game object tagged "fire"
    }

    public void InflictDamageToPlayer() // check if player is too close, and inflict damage
    {
        foreach (GameObject fire in fires)
        {
            // plus le joueur est proche du feu plus le dommage est important
            float distance = Vector3.Distance(hero.transform.position, fire.transform.position);
            
            if (distance <= 15 && distance > 10)
            {
                hero.TakeDamage(1);
            }
            else if (distance <= 10 && distance > 5)
            {
                hero.TakeDamage(2);
            }
            else if (distance <= 5)
            {
                hero.TakeDamage(3);
            }
        }
    }
}
