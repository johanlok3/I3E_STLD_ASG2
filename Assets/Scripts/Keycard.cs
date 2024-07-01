/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: Treasure chest interactable Script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycard : MonoBehaviour, IInteractable
{
    // put here so can call the other scripts method
    public Player keyCardCheck;

    // put the text and background here as variables
    public GameObject keyCardCollect;

    public GameObject keyCardText;

    // Destroys the chest when collected and prints out message
    public void Collected()
    {
        // cahnges the bool value of the Player and destroys the keycard
        keyCardCheck.keyCard = true;
        Debug.Log("Keycard COLLECTED!");
        Destroy(gameObject);
    }

    public void Interact()
    {
        // when you press e the keycard will be collected
        Collected();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // when colliding with the keycard the message will show
        keyCardCollect.SetActive(true);
        keyCardText.SetActive(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        // First frame the message is not showing
        keyCardCollect.SetActive(false);
        keyCardText.SetActive(false);
    }





    // Start is called before the first frame update
    void Start()
    {
        keyCardCollect.SetActive(false);
        keyCardText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
