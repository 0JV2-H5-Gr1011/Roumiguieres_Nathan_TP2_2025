using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int scoreRecyclage = 0;
    public int scoreComposte = 0;
    public int scorePoubelle = 0;

    public TextMeshProUGUI texteRecyclage;
    public TextMeshProUGUI texteComposte;
    public TextMeshProUGUI textePoubelle;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AjouterScore(RecupDechets.TypeDechet type)
    {
        switch (type)
        {
            case RecupDechets.TypeDechet.Recyclage:
                scoreRecyclage++;
                break;
            case RecupDechets.TypeDechet.Composte:
                scoreComposte++;
                break;
            case RecupDechets.TypeDechet.Poubelle:
                scorePoubelle++;
                break;
        }

        MettreAJourUI();
    }

    public void ReinitialiserScore(RecupDechets.TypeDechet type)
    {
        switch (type)
        {
            case RecupDechets.TypeDechet.Recyclage:
                scoreRecyclage = 0;
                break;
            case RecupDechets.TypeDechet.Composte:
                scoreComposte = 0;
                break;
            case RecupDechets.TypeDechet.Poubelle:
                scorePoubelle = 0;
                break;
        }

        MettreAJourUI();
    }

    public void MettreAJourUI()
    {
        if (texteRecyclage != null)
            texteRecyclage.text = "Recyclage : " + scoreRecyclage;
        if (texteComposte != null)
            texteComposte.text = "Composte : " + scoreComposte;
        if (textePoubelle != null)
            textePoubelle.text = "Poubelle : " + scorePoubelle;
    }
}