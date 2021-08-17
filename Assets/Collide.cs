using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public GameObject clueUi;

    private void OnTriggerEnter(Collider other)
    {
        clueUi.SetActive(true);
        Destroy(gameObject);
    }
}
