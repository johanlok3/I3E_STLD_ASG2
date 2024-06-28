using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftBox : MonoBehaviour, IInteractable
{
    [SerializeField]
    private GameObject collectibleToSpawn;
    [SerializeField]
    private AudioClip collectAudio;


    public void Interact()
    {
        AudioSource.PlayClipAtPoint(collectAudio, transform.position, 1f);
        SpawnCollectible();
        Destroy(gameObject);
    }






    void SpawnCollectible()
    {
        Instantiate(collectibleToSpawn, transform.position, collectibleToSpawn.transform.rotation);
    }
}
