using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateTimer(float timer)
    {
        timerText.text = "00:" + (int)timer;
    }
    public void ShowLoseMessage()
    {
    timerText.text = "PERDISTE";
    }
    public void ShowWinMessage()
    {
    timerText.text = "GANASTE";
    }
}