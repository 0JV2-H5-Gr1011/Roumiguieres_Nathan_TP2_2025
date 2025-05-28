/*using System.Collections;
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
        // Récupère la valeur sauvegardée ou met 0.8 par défaut
        float savedVolume = PlayerPrefs.GetFloat("Volume", 0.8f);
        volumeSlider.value = savedVolume;
        SetVolume(savedVolume);

        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float value)
    {
        float volumeDB = Mathf.Log10(Mathf.Clamp(value, 0.0001f, 1f)) * 20;
        mixer.SetFloat("Volume", volumeDB);

        // Sauvegarde la valeur pour les prochaines scènes
        PlayerPrefs.SetFloat("Volume", value);
        PlayerPrefs.Save();
    }
}*/