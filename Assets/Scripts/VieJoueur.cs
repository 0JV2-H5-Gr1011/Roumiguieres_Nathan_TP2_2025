using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // si tu veux relancer ou changer de scène
using TMPro;

public class VieJoueur : MonoBehaviour
{
    public int vies = 5;
    public float delaiInvincibilite = 2f;
    private bool estInvincible = false;

    public TextMeshProUGUI viesText;

    public AudioSource audioSource;
    public AudioClip sonDegat; // Drag ton son ici dans l'inspector

    void Start()
    {
        MettreAJourUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ennemi") && !estInvincible)
        {
            vies--;

            // Joue le son
            if (sonDegat != null && audioSource != null)
            {
                audioSource.PlayOneShot(sonDegat);
            }

            MettreAJourUI();

            if (vies <= 0)
            {
                SceneManager.LoadScene("Fin");
            }
            else
            {
                StartCoroutine(InvincibiliteTemporaire());
            }
        }
    }

    void MettreAJourUI()
    {
        if (viesText != null)
        {
            viesText.text = "Vies : " + vies;
        }
    }

    IEnumerator InvincibiliteTemporaire()
    {
        estInvincible = true;
        yield return new WaitForSeconds(delaiInvincibilite);
        estInvincible = false;
    }
}
