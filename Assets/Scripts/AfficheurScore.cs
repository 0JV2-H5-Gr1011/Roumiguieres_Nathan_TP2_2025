using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfficheurScore : MonoBehaviour
{
    public TextMeshProUGUI recyclageText;
    public TextMeshProUGUI composteText;
    public TextMeshProUGUI poubelleText;

    void Update()
    {
        recyclageText.text = "Recyclage : " + RecupDechets.scoreRecyclage;
        composteText.text = "Composte : " + RecupDechets.scoreComposte;
        poubelleText.text = "Poubelle : " + RecupDechets.scorePoubelle;
    }
}
