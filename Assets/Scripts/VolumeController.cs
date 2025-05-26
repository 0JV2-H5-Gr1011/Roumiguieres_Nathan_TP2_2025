using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider volumeSlider;

    void Start()
    {
        // Définir une valeur de départ par défaut
        volumeSlider.value = 0.8f;
        SetVolume(volumeSlider.value);

        // Ajouter l'écouteur d'événement
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float value)
    {
        // Convertir 0.0–1.0 vers dB (-80 à 0)
        float volumeDB = Mathf.Log10(Mathf.Clamp(value, 0.0001f, 1f)) * 20;
        mixer.SetFloat("Volume", volumeDB);
    }
}