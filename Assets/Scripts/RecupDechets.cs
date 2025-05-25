using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RecupDechets : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Ignore tout sauf les objets tagg�s "Player"
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

