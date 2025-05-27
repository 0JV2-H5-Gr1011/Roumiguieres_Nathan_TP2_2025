using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoubelleOuvrePorte : MonoBehaviour
{
    public GameObject porteGauche;  // À assigner dans l’inspecteur
    public GameObject porteDroite;  // À assigner dans l’inspecteur
    public Animator animGauche;     // Si tu veux jouer une anim
    public Animator animDroite;

    private bool porteOuverte = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !porteOuverte)
        {
            if (RecupDechets.scoreRecyclage + RecupDechets.scoreComposte + RecupDechets.scorePoubelle >= 8)
            {
                porteOuverte = true;

                // Si tu utilises une animation
                if (animGauche != null && animDroite != null)
                {
                    animGauche.SetTrigger("Ouvrir");
                    animDroite.SetTrigger("Ouvrir");
                }
                else
                {
                    // Sinon on peut désactiver les portes ou les faire pivoter
                    porteGauche.SetActive(false);
                    porteDroite.SetActive(false);
                }

                Debug.Log("La porte s'ouvre !");
            }
            else
            {
                Debug.Log("Tu n'as pas assez de déchets !");
            }
        }
    }
}
