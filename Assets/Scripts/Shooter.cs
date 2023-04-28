using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    
    public Rigidbody projectile;
    public Transform mySpawn;
    public float fireRate = 0.5f; // The time (in seconds) between shots
    private float timer = 0f; // The timer that keeps track of the time elapsed


    void Update()
    {
        timer += Time.deltaTime; // Increment the timer by the time elapsed since the last frame

        if (Input.GetButton("Fire1") && timer >= fireRate)
        {
            Shoot();
            timer = 0f; // Reset the timer
        }
    }

    void Shoot()
    {
        Rigidbody bullet = Instantiate(projectile, mySpawn.position, mySpawn.rotation);
        bullet.velocity = mySpawn.forward * 50;
        
    }
}