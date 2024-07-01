/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: Script for any object that requires something to happen when mouse is hovered over it
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouseHoverScript : MonoBehaviour
{
    // Here you can put the text you want to show when mouse hovers
    public GameObject infoText;

    // Here you can put the image you want to show when mouse hovers
    public GameObject messageBox;

    // When the players mouse is hovering on the object the messagebox and text will appear
    public void OnMouseOver()
    {
        infoText.SetActive(true);
        messageBox.SetActive(true);
    }

    // When the players mouse is moved off of the object the messagebox and text will disappear
    public void OnMouseExit()
    {
        infoText.SetActive(false);
        messageBox.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Make sure the messagebox and text is not showing on first frame
        infoText.SetActive(false);
        messageBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
