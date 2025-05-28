using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetourAccueil : MonoBehaviour
{
    public void RevenirAccueil()
    {
        SceneManager.LoadScene("Accueil");
    }
}
