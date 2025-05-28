using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerScene : MonoBehaviour
{
    public string nomScene;
    public bool estDeverrouillee = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (estDeverrouillee)
            {
                Debug.Log("Porte déverrouillée, changement vers la scène : " + nomScene);
                SceneManager.LoadScene(nomScene);
            }
            else
            {
                Debug.Log("Porte verrouillée, tu dois d’abord toucher la poubelle !");
            }
        }
    }

    public void Deverrouiller()
    {
        estDeverrouillee = true;
    }
}