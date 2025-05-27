using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoubelleTriggerNiv2 : MonoBehaviour
{
    public RecupDechets.TypeDechet typePoubelle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.ReinitialiserScore(typePoubelle);
        }
    }
}  
