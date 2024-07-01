/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: Change scene Script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string scenename;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            SceneManager.LoadScene(scenename);
        }
    }
}