using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // si tu veux relancer ou changer de scène
using TMPro;

public class VieJoueur : MonoBehaviour
{
    public int vies = 5;
    public float delaiInvincibilite = 2f; // Temps invincible après un coup
    private bool estInvincible = false;

    public TextMeshProUGUI viesText; // À lier dans l’inspector

    void Start()
    {
        MettreAJourUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ennemi") && !estInvincible)
        {
            vies--;
            Debug.Log("Touché ! Vies restantes : " + vies);
            MettreAJourUI();

            if (vies <= 0)
            {
                Debug.Log("Game Over !");
                // Recharge la scène actuelle
                SceneManager.LoadScene("FinPerdu");
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