using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
     
    public Rigidbody projectile;
    public Transform mySpawn;
    public float fireRate = 0.5f;
    public float bulletLifetime = 0.5f;
    public float maxDistance = 50f;
    public GameObject allowedPlane; // Objeto del plano permitido
    private float timer = 0f;
    public GameObject terrainObject;
    public AudioClip sound;

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetButton("Fire1") && timer >= fireRate)
        {
            Shoot();
            timer = 0f;
        }
    }

    void Shoot()
    {
        float speed = maxDistance / bulletLifetime;
        Rigidbody bullet = Instantiate(projectile, mySpawn.position, mySpawn.rotation);
        bullet.velocity = mySpawn.forward * speed;
        bullet.gameObject.AddComponent<BulletController>(); // Agrega el script BulletController a la bala
        
        AudioSource.PlayClipAtPoint(sound,transform.position);

        bullet.GetComponent<BulletController>().hitMaterial = GetComponent<MeshRenderer>().material; // Asigna el material actual de la bala al script BulletController
         Destroy(bullet.gameObject, bulletLifetime); // Destroy the bullet after bulletLifetime seconds

    }



}
