using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RecupDechetsNiv1 : MonoBehaviour
{
    public static int score = 0; // score global
    public TextMeshProUGUI scoreText; // à assigner dans l'inspecteur

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            score++; // augmente le score
            UpdateScoreText(); // met à jour l'affichage
            Destroy(gameObject); // détruit le déchet
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score : " + score;
        }
        else
        {
            Debug.LogWarning("Aucun texte de score assigné !");
        }
    }
}
