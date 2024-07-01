/*
 * Author: Johan Loke
 * Date: 30/6/2024
 * Description: Script for Gundata    
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor2 : MonoBehaviour
{
    [SerializeField] public Animator myDoor = null;

    [SerializeField] public bool openTrigger = false;

    [SerializeField] public string doorOpen = "DoorOpen";

    public void OnTriggerEnter(Collider other)
    {
        myDoor.Play(doorOpen, 0, 0.0f);
        gameObject.SetActive(false);
    }
}
