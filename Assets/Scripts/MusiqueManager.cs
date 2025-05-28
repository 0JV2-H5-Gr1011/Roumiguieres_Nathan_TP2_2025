/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusiqueManager : MonoBehaviour
{
    public static MusiqueManager instance;

    public AudioMixer mixer; // à assigner dans l'inspector (le mixer global)
    public AudioSource audioSource; // à assigner dans l'inspector (celui qui joue la musique)

    public string volumeParameterName = "Volume"; // nom du paramètre exposé dans le mixer

    private void Awake()
    {
        // Singleton pattern
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Charger et appliquer le volume sauvegardé dans PlayerPrefs
        float savedVolume = PlayerPrefs.GetFloat(volumeParameterName, 0.8f);
        SetVolume(savedVolume);
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Accueil") audioSource.clip = musiqueAccueil;
        // Ici tu peux changer la musique selon la scène, si tu veux.
        // Par exemple :
        // if (scene.name == "Accueil") audioSource.clip = musiqueAccueil;
        // else if (scene.name == "Niveau1") audioSource.clip = musiqueNiveau1;
        // audioSource.Play();

        // Sinon laisse juste la musique tourner
    }

    // Appelée par le slider ou autre
    public void SetVolume(float value)
    {
        // Sauvegarder la valeur
        PlayerPrefs.SetFloat(volumeParameterName, value);
        PlayerPrefs.Save();

        // Convertir le slider (0..1) en dB (-80..0)
        float volumeDB = Mathf.Log10(Mathf.Clamp(value, 0.0001f, 1f)) * 20;
        mixer.SetFloat(volumeParameterName, volumeDB);
    }
}*/