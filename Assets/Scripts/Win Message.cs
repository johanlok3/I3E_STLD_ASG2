using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class WinMessage : MonoBehaviour, IInteractable
{
    public GameObject winImage;
    public GameObject winMessage;
    public GameObject quitOption;

    public void Interact()
    {
        winImage.SetActive(true);
        winMessage.SetActive(true);
        quitOption.SetActive(true);
    }
    
    void Start()
    {
        winImage.SetActive(false);
        winMessage.SetActive(false);
        quitOption.SetActive(false);
    }
}
