/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: Coin Script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour, IInteractable
{
    [SerializeField]
    private AudioClip collectAudio;


    // Values for the coin collectible including score 
    int myScore = 5;
    string myItem = "Coins";
    bool isCollected = false;
    bool itemCollected = false;
    float itemRarity = 0.05f;


    // Destroys the coin when collected and prints out message
    public void Interact()
    {
        AudioSource.PlayClipAtPoint(collectAudio, transform.position, 1f);
        Debug.Log("Coin collected.");
        Destroy(gameObject);
    }

    void Spawn()
    {
        
    
    }

    void Expire()
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
