using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitterJeu : MonoBehaviour
{
    public void Quitter()
    {
        Debug.Log("Quitter le jeu...");
        Application.Quit();
    }
}
