using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonSon : MonoBehaviour
{
    public AudioSource audioSource;

    public void JouerSon()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}