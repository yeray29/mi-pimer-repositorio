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

    private int numbreOfClick = 0;
    public Text NumbreOfClickText;

    private void Start()
    {
    }

    public void Click()
    {
        numbreOfClick++;
        NumbreOfClickText.text = numbreOfClick.ToString();
    }

    public void Restard()
    {
        numbreOfClick = 0;
        NumbreOfClickText.text = numbreOfClick.ToString();
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
            timeLeftText.text = timeLeft.ToString();
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
    }
}