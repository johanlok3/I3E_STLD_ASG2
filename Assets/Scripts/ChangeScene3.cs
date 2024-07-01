/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: Change scene Script for castle
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene3 : MonoBehaviour
{
    public string scenename;
    public GameObject message;
    public GameObject text;

    public Crystal collect;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (collect.crystalCollected == true)
            {
                SceneManager.LoadScene(scenename);
            }

            else if (collect.crystalCollected == false)
            {
                text.SetActive(true);
                message.SetActive(true);
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        message.SetActive(false);
    }


    void Start()
    {
        // Make sure first frame none of the messages show
        text.SetActive(false);
        message.SetActive(false);
    }

}