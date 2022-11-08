using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour
{
    public GameObject statPanel, gamePanel, endPanel;

    public Text timeLeftText;
    public float playTime;
    public float timeLeft;

    private bool timeIsTicking = false;

    private int numberOfClick = 0;
    public int targetNumbreOfClick = 10;
    public Text NumbreOfClickText;
    public Text gameOverText;
    private string maxScoreKey = "maxScore";

    public void Click()
    {
        numberOfClick++;
        NumbreOfClickText.text = numberOfClick.ToString();
    }

    public void Restard()
    {
        numberOfClick = 0;
        NumbreOfClickText.text = numberOfClick.ToString();
    }

    public void startCountDonw()
    {
        timeLeft = playTime;
        timeIsTicking = true;
    }

    private void Update()
    {
        if (timeIsTicking)
        {
            timeLeft -= Time.deltaTime;
            timeLeftText.text = timeLeft.ToString("0.00");
            if (timeLeft < 0)
            {
                timeIsTicking = false;
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        gamePanel.SetActive(false);
        endPanel.SetActive(true);
        CheckWinningConditions();
    }

    private void CheckWinningConditions()
    {
        if (numberOfClick >= targetNumbreOfClick)
        {
            int maxScore = PlayerPrefs.GetInt(maxScoreKey);
            if (numberOfClick > maxScore)
            {
                gameOverText.text = "felicidades has clikado " + numberOfClick +
                    " de los " + targetNumbreOfClick + " has alcanzado un nuevo record";
                PlayerPrefs.SetInt(maxScoreKey, numberOfClick);
            }
            else
            {
                gameOverText.text = "felicidades has clikado " + numberOfClick +
                    " de los " + targetNumbreOfClick + " necesarios, el record som " + maxScore;
            }
        }
        else
        {
            gameOverText.text = "lo siento pero no lo has conseguido";
        }
    }
}