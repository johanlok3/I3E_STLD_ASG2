/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: Coin Script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Values for the coin collectible including score 
    int myScore = 5;
    string myItem = "Coins";
    bool isCollected = false;
    bool itemCollected = false;
    float itemRarity = 0.05f;


    // Destroys the coin when collected and prints out message
    public void Collected()
    {
        Debug.Log("Coin collected.");
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Makes it so the coin only gets collected if the player collides with it
        if (collision.gameObject.tag == "Player")
        {
            // Increasescore function will get called, adding the score of the coin
            // Collected function will also get called
            // Deductcollectible function will get called, deducting the total collectibles remaining by 1
            collision.gameObject.GetComponent<Player>().IncreaseScore(myScore);
            Collected();
        }
    }


    void Spawn()
    {
        
    
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
