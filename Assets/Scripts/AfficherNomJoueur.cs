using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfficherNomJoueur : MonoBehaviour
{
    public TextMeshProUGUI texteNom; // L’élément où tu veux afficher le nom

    void Start()
    {
        texteNom.text = NomJoueurManager.nomJoueur;
    }
}
