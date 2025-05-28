using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuverturePorte : MonoBehaviour
{
    public Animator porteGaucheAnimator;
    public Animator porteDroiteAnimator;
    public int totalDechetsRequis = 8;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger détecté avec : " + other.name);
        if (other.CompareTag("Player"))
        {
            int totalDechets = RecupDechets.scoreRecyclage + RecupDechets.scoreComposte + RecupDechets.scorePoubelle;
            Debug.Log("Total déchets : " + totalDechets);

            if (totalDechets >= totalDechetsRequis)
            {
                Debug.Log("Ouverture porte déclenchée !");
                porteGaucheAnimator.SetTrigger("Ouvrir");
                porteDroiteAnimator.SetTrigger("Ouvrir");
            }
            else
            {
                Debug.Log("Il manque des déchets !");
            }
        }
    }
}