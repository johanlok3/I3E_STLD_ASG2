/*
 * Author: Johan Loke
 * Date: 30/6/2024
 * Description: Script for Gundata    
*/
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GunData : MonoBehaviour
{
    //Gun stats
    public int damage;
    public float fireRate, range, reloadTime, timeBetweenShots;
    public int magazineSize, bulletsPerTap;
    public bool allowButtonHold;
    int bulletsLeft, bulletsShot;

    //bools
    bool shooting, readyToShoot, reloading;

    //Reference
    public Camera fpsCam;
    public Transform attackPoint;
    public RaycastHit rayHit;
    public LayerMask whatIsEnemy;

    //Graphics
    public GameObject muzzleFlash;
    public Transform muzzleFlashPosition;
    public TextMeshProUGUI text;
    public AudioSource gunSound;
    public AudioSource reloadSound;

    private void Awake()
    {
        bulletsLeft = magazineSize;
        readyToShoot = true;
    }
    private void Update()
    {
        MyInput();

        //SetText
        text.SetText(bulletsLeft + " / " + magazineSize);
    }
    private void MyInput()
    {
        if (allowButtonHold) shooting = Input.GetKey(KeyCode.Mouse0);
        else shooting = Input.GetKeyDown(KeyCode.Mouse0);

        if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading) Reload();

        //Shoot
        if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            bulletsShot = bulletsPerTap;
            Shoot();
        }
    }
    private void Shoot()
    {
        //Graphics
        GameObject Flash = Instantiate(muzzleFlash, muzzleFlashPosition);
        Destroy(Flash, 0.1f);


        readyToShoot = false;

        //RayCast
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out rayHit, range, whatIsEnemy))
        {
            Debug.Log(rayHit.collider.name);

            //if (rayHit.collider.CompareTag("Enemy"))
            //rayHit.collider.GetComponent<EnemyAI>().TakeDamage(damage);
        }

        gunSound.Play();

        bulletsLeft--;
        bulletsShot--;

        Invoke("ResetShot", fireRate);

        if (bulletsShot > 0 && bulletsLeft > 0)
            Invoke("Shoot", timeBetweenShots);
    }



    private void ResetShot()
    {
        readyToShoot = true;
    }


    private void Reload()
    {
        reloadSound.Play();

        reloading = true;
        Invoke("ReloadFinished", reloadTime);
    }


    private void ReloadFinished()
    {
        bulletsLeft = magazineSize;
        reloading = false;
    }



}
