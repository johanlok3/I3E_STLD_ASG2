using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage;
    public Player damaged;

    public void OnCollisionEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            damaged.DamageTaken(bulletDamage);
        }
    }
}
