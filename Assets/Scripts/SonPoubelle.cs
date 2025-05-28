using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonPoubelle : MonoBehaviour
{
    public AudioSource audioSource;  // À assigner dans l'inspector (un AudioSource avec le son)
    public AudioClip sonPoubelle;    // Le clip audio à jouer

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (audioSource != null && sonPoubelle != null)
            {
                audioSource.PlayOneShot(sonPoubelle);
            }
        }
    }
}