/*
 * Author: Johan Loke
 * Date: 13/5/2024
 * Description: SCript for interator    
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Make a public interface for all scripts to use the function
interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;

    public float InteractRange;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame to check if player is within range of object
    void Update()
    {
        // Input is registered if player presses E key
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            // Updates if player is whithin range of interaction
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                // If the player interacts with the obj, Interact() function will be called
                if (hitInfo.collider.gameObject.TryGetComponent (out IInteractable interactObj)) 
                {
                    interactObj.Interact();
                }
            }
        }
    }
}
