﻿
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public enum Scores
    {
        AiScore, PlayerScore



    }
 public Text AiScoreTxt, PlayerScoreTxt;
 private int aiScore, playerScore;

public void Increment(Scores whichScore)
{
    if(whichScore == Scores.AiScore)
        AiScoreTxt.text = "AI: " + (++aiScore).ToString();
    else
        PlayerScoreTxt.text = "Player: " + (++playerScore).ToString();




}



}
