using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    public GameObject gameOverText;
    public GameObject player;
    public GameObject puck;
    public Text PlayerScoreText;
    public Text AIScoreText;
    public int PlayerScore = 0;
    public int AIScore = 0;
    //public GameObject AI; set this later

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        gameOverText.SetActive(false);
        DisplayTime(timeRemaining);
        PlayerScoreText.text = "Player: " + PlayerScore;
        AIScoreText.text = "AI: " + AIScore;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                gameOverText.SetActive(true);
                player.SetActive(false);
                puck.SetActive(false); //disable them, but if game goes to OT, then reactivate
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText = GameObject.Find("TimeText").GetComponent<Text>();
        timeText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
