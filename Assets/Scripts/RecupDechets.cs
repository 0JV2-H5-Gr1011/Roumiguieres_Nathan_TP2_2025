using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecupDechets : MonoBehaviour
{
    public enum TypeDechet { Recyclage, Composte, Poubelle }
    public TypeDechet type;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AjouterScore(type);
            Destroy(gameObject);
        }
    }
}