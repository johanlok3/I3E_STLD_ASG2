/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: Door that opens only on certain criteria
*/
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    // Put this in so i can call the variable from the Player script
    public Player scoreCount;

    // Then i put two gameobjects to display the DOOR IS LOCKED message
    public GameObject doorIsLocked;

    public GameObject doorLockedText;

    // This method unlocks the door
    private void DoorUnlocks()
    {
        Debug.Log("Door opened.");
        Destroy(gameObject);
    }

    // This one makes it so you have to get more than 120 points to unlock the door
    public void OnCollisionEnter(Collision collision)
    {
        // If you dont have 120 points the message telling you to get mroe points will show
        // when you collide with the door
        if (scoreCount.currentScore >= 120)
        {
            DoorUnlocks();
        }

        else
        {
            doorIsLocked.SetActive(true);
            doorLockedText.SetActive(true);
        }
    }

    // When you move away from the door the message will disappear
    private void OnCollisionExit(Collision collision)
    {
        doorIsLocked.SetActive(false);
        doorLockedText.SetActive(false);

    }

    // Start is called before the first frame update
    void Start()
    {
        // Make sure first frame none of the messages show
        doorIsLocked.SetActive(false);
        doorLockedText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
