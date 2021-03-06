﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HighscoreText : MonoBehaviour
{
    Text highScore;

    void OnEnable()
    {
        highScore = GetComponent<Text>();
        highScore.text = "High Score: " +  PlayerPrefs.GetInt("HighScore").ToString();
    }
}
