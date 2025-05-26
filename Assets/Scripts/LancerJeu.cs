using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LancerJeu : MonoBehaviour
{
    public void ChargerScene()
    {
        SceneManager.LoadScene("Niveau1");
    }
}