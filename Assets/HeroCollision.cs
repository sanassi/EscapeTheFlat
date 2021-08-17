using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCollision : MonoBehaviour
{
    //useless class : don't forget to delete after
    public Hero hero;

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Fire")
        {
            hero.TakeDamage(10);
        }
    }

    public void HeroIsNearFire(float minimunDistance)
    {
        GameObject[] fires = GameObject.FindGameObjectsWithTag("Fire");

        Debug.Log(fires.Length);
        foreach (GameObject fire in fires)
        {
            if (Vector3.Distance(hero.transform.position, fire.transform.position) <= 20)
            {
                Debug.Log("FIRE IS NEAR");
                hero.TakeDamage(10);
            }
        }
    }
}
