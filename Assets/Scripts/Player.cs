/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: Player script
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;


public class Player : MonoBehaviour
{
    // This textbox is for score
    public TextMeshProUGUI scoreText;

    public int health;

    // Currentscore of the player is set to 0
    public int currentScore = 0;

    // Updates players current score in real time
    public void IncreaseScore(int scoreToAdd)
    {           
        // Add score collected to players current score 
        currentScore += scoreToAdd;

        // Display current score on player's UI
        scoreText.text = currentScore.ToString();
    }

    public void DamageTaken(int damage)
    {
        health -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
