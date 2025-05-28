using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RecupDechetsNiv1 : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject poubelle;

    void Start()
    {
        scoreText.text = "Score : " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dechet"))
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = "Score : " + score;

            if (score >= 8)
            {
                poubelle.SetActive(true);
            }
        }
    }
}