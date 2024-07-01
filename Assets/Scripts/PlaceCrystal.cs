using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCrystal : MonoBehaviour, IInteractable
{
    public GameObject Crystal;

    public void Interact()
    {
        Instantiate(Crystal, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
