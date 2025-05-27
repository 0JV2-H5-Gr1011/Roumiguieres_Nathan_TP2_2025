using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfficherStatsFinales : MonoBehaviour
{
    public TextMeshProUGUI recyclageText;
    public TextMeshProUGUI composteText;
    public TextMeshProUGUI poubelleText;

    public TextMeshProUGUI compteurRecyclageText;
    public TextMeshProUGUI compteurComposteText;
    public TextMeshProUGUI compteurPoubelleText;

    void Start()
    {
        // Affiche les scores de déchets ramassés
        recyclageText.text = "Déchets recyclage ramassés : " + RecupDechets.scoreTotalRecyclage;
        composteText.text = "Déchets compostés ramassés : " + RecupDechets.scoreTotalComposte;
        poubelleText.text = "Déchets poubelle ramassés : " + RecupDechets.scoreTotalPoubelle;

        // Affiche les compteurs de poubelles touchées (exemple : variables statiques dans PoubelleTrigger)
        compteurRecyclageText.text = "Poubelles recyclage touchées : " + PoubelleTriggerNiv2.compteurRecyclage;
        compteurComposteText.text = "Poubelles compost touchées : " + PoubelleTriggerNiv2.compteurComposte;
        compteurPoubelleText.text = "Poubelles poubelle touchées : " + PoubelleTriggerNiv2.compteurPoubelle;
    }
}
