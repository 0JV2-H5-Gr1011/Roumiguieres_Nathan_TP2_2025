using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonPoubelle : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sonPoubelle;

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