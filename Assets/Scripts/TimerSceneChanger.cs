using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using TMPro;

public class TimerSceneChanger : MonoBehaviour
{
    public float timeRemaining = 600f; // 10 minutes = 600 secondes
    public TextMeshProUGUI timerText;

    private bool timerIsRunning = true;

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerDisplay(timeRemaining);
            }
            else
            {
                timerIsRunning = false;
                timeRemaining = 0;
                UpdateTimerDisplay(timeRemaining);
                SceneManager.LoadScene("Fin"); // Remplace "Fin" par le nom exact de ta scène
            }
        }
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}