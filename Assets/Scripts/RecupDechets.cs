using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RecupDechets : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Ignore tout sauf les objets taggés "Player"
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

