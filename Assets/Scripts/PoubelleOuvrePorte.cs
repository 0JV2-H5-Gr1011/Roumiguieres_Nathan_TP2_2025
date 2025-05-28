using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoubelleOuvrePorte : MonoBehaviour
{
    public GameObject porteGauche;
    public GameObject porteDroite;
    public Animator animGauche;
    public Animator animDroite;

    private bool porteOuverte = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !porteOuverte)
        {
            if (RecupDechets.scoreRecyclage + RecupDechets.scoreComposte + RecupDechets.scorePoubelle >= 8)
            {
                porteOuverte = true;
                if (animGauche != null && animDroite != null)
                {
                    animGauche.SetTrigger("Ouvrir");
                    animDroite.SetTrigger("Ouvrir");
                }
                else
                {
                    porteGauche.SetActive(false);
                    porteDroite.SetActive(false);
                }

                Debug.Log("La porte s'ouvre");
            }
            else
            {
                Debug.Log("Tu n'as pas assez de déchets");
            }
        }
    }
}
