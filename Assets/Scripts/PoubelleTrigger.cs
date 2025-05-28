using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoubelleTrigger : MonoBehaviour
{
    public ChangerScene scriptPorte;
    public RecupDechetsNiv1 recupDechets;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player a touché la poubelle, score = " + recupDechets.score);

            if (recupDechets.score >= 8)
            {
                Debug.Log("Score suffisant, déverrouillage de la porte");
                scriptPorte.Deverrouiller();
            }
            else
            {
                Debug.Log("Score insuffisant, ramasse plus de déchets !");
            }
        }
    }
}