using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoubelleTriggerNiv2 : MonoBehaviour
{
    public RecupDechets.TypeDechet typePoubelle;

    public static int compteurRecyclage = 0;
    public static int compteurComposte = 0;
    public static int compteurPoubelle = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (typePoubelle)
            {
                case RecupDechets.TypeDechet.Recyclage:
                    RecupDechets.scoreRecyclage = 0;
                    compteurRecyclage++;
                    break;
                case RecupDechets.TypeDechet.Composte:
                    RecupDechets.scoreComposte = 0;
                    compteurComposte++;
                    break;
                case RecupDechets.TypeDechet.Poubelle:
                    RecupDechets.scorePoubelle = 0;
                    compteurPoubelle++;
                    break;
            }
        }
    }
}