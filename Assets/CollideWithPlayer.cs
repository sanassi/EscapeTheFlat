using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPlayer : MonoBehaviour
{
    public Hero hero;

    public float timeAdded = 30f;

    public Timer timer;

    private void OnTriggerEnter(Collider other)
    {
        timer.AddTime(timeAdded);
        Destroy(gameObject);
    }
}
