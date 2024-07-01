/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: Change scene Script for castle
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene2 : MonoBehaviour
{
    public string scenename;

    public Player scoreCount;

    public GameObject doorLocked;
    public GameObject doorLockedText;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (scoreCount.currentScore >= 50)
            {
                SceneManager.LoadScene(scenename);
            }

            else if (scoreCount.currentScore < 50)
            {
                doorLocked.SetActive(true);
                doorLockedText.SetActive(true);
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        doorLocked.SetActive(false);
        doorLockedText.SetActive(false);
    }


    void Start()
    {
        // Make sure first frame none of the messages show
        doorLocked.SetActive(false);
        doorLockedText.SetActive(false);
    }

}