using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonDechet : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sonDechet;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (audioSource != null && sonDechet != null)
            {
                audioSource.PlayOneShot(sonDechet);
            }
        }
    }
}