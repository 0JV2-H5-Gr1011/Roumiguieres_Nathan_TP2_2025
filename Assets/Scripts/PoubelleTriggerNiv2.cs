using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoubelleTriggerNiv2 : MonoBehaviour
{
    public RecupDechets.TypeDechet typePoubelle; // Assigné dans l’inspecteur selon la poubelle (Recyclage, Composte, Poubelle)

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (typePoubelle)
            {
                case RecupDechets.TypeDechet.Recyclage:
                    RecupDechets.scoreRecyclage = 0;
                    Debug.Log("Score recyclage remis à 0");
                    break;
                case RecupDechets.TypeDechet.Composte:
                    RecupDechets.scoreComposte = 0;
                    Debug.Log("Score compost remis à 0");
                    break;
                case RecupDechets.TypeDechet.Poubelle:
                    RecupDechets.scorePoubelle = 0;
                    Debug.Log("Score poubelle remis à 0");
                    break;
            }
        }
    }
}
