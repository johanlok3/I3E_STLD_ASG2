/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: Treasure chest interactable Script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour, IInteractable
{
    public bool crystalCollected;

    public void Interact()
    {
        // cahnges the bool value of the Player and destroys the keycard
        crystalCollected = true;
        Debug.Log("Crystal COLLECTED!");
        Destroy(gameObject);
    }
}
