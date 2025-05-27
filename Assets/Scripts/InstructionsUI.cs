using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsUI : MonoBehaviour
{
    public GameObject panneauInstructions;

    public void AfficherInstructions()
    {
        panneauInstructions.SetActive(true);
    }

    public void FermerInstructions()
    {
        panneauInstructions.SetActive(false);
    }
}