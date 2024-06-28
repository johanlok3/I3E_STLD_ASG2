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

    // Currentscore of the player is set to 0
    public int currentScore = 0;

    // Player does not have keycard so this is false
    public bool keyCard = false;

    // Updates players current score in real time
    public void IncreaseScore(int scoreToAdd)
    {           
        // Add score collected to players current score 
        currentScore += scoreToAdd;

        // Display current score on player's UI
        scoreText.text = currentScore.ToString();
    }


    // Start is called before the first frame update
    void Start()
    {
        keyCard = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
