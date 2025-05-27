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
        if (other.CompareTag("Player"))
        {
            int totalDechets = RecupDechets.scoreRecyclage + RecupDechets.scoreComposte + RecupDechets.scorePoubelle;

            if (totalDechets >= totalDechetsRequis)
            {
                porteGaucheAnimator.SetTrigger("Ouvrir");
                porteDroiteAnimator.SetTrigger("Ouvrir");
                Debug.Log("La porte s'ouvre !");
            }
            else
            {
                Debug.Log("Il manque des déchets !");
            }
        }
    }
}