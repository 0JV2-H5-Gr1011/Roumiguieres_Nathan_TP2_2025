using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecupDechets : MonoBehaviour
{
    public enum TypeDechet { Recyclage, Composte, Poubelle }
    public TypeDechet type;

    public static int scoreRecyclage = 0;
    public static int scoreComposte = 0;
    public static int scorePoubelle = 0;

    public static int scoreTotalRecyclage = 0;
    public static int scoreTotalComposte = 0;
    public static int scoreTotalPoubelle = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (type)
            {
                case TypeDechet.Recyclage:
                    scoreRecyclage++;
                    scoreTotalRecyclage++;
                    break;
                case TypeDechet.Composte:
                    scoreComposte++;
                    scoreTotalComposte++;
                    break;
                case TypeDechet.Poubelle:
                    scorePoubelle++;
                    scoreTotalPoubelle++;
                    break;
            }

            Destroy(gameObject);
        }
    }
}