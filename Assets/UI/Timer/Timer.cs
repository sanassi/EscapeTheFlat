using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeRemaining = 20f;
    private bool timerIsRunning;
    public TextMeshProUGUI timeText;

    public GameManager gameManager;
    public bool TimerIsRunning => timerIsRunning;

    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        RunTimer();
    }

    public void AddTime(float time)
    {
        timeRemaining += time;
    }

    void RunTimer()
    {
        if (timeRemaining >= 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            timeRemaining = 0;
            timerIsRunning = false;
            gameManager.EndGame();
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
