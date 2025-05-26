using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RecupDechets : MonoBehaviour
{
    public enum TypeDechet { Recyclage, Composte, Poubelle }
    public TypeDechet type; // assigner dans l'inspecteur sur chaque déchet

    public static int scoreRecyclage = 0;
    public static int scoreComposte = 0;
    public static int scorePoubelle = 0;

    public TextMeshProUGUI scoreRecyclageText;
    public TextMeshProUGUI scoreComposteText;
    public TextMeshProUGUI scorePoubelleText;

    private void Start()
    {
        UpdateAllScoreTexts();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (type)
            {
                case TypeDechet.Recyclage:
                    scoreRecyclage++;
                    break;
                case TypeDechet.Composte:
                    scoreComposte++;
                    break;
                case TypeDechet.Poubelle:
                    scorePoubelle++;
                    break;
            }

            UpdateAllScoreTexts();
            Destroy(gameObject);
        }
    }

    private void UpdateAllScoreTexts()
    {
        if (scoreRecyclageText != null)
            scoreRecyclageText.text = "Recyclage : " + scoreRecyclage;
        if (scoreComposteText != null)
            scoreComposteText.text = "Composte : " + scoreComposte;
        if (scorePoubelleText != null)
            scorePoubelleText.text = "Poubelle : " + scorePoubelle;
    }
}