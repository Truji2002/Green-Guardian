using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform mySpawn;
    public float fireRate = 0.5f; // The time (in seconds) between shots
    public float bulletLifetime = 5f; // The time (in seconds) that bullets will exist before being destroyed
    public float maxDistance = 50f; // The maximum distance (in units) that bullets can travel
    public GameObject treePrefab; // The prefab for the tree object
    public Material seedMaterial; // The material for the seed object
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
        float speed = maxDistance / bulletLifetime; // Calculate the speed required to travel the maximum distance in the given lifetime
        Rigidbody bullet = Instantiate(projectile, mySpawn.position, mySpawn.rotation);
        bullet.velocity = mySpawn.forward * speed; // Set the velocity of the bullet to the required speed
        bullet.GetComponent<Renderer>().material = seedMaterial; // Set the material of the bullet to the seed material
        Destroy(bullet.gameObject, bulletLifetime); // Destroy the bullet after bulletLifetime seconds
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SueloApto"))
        {
            GameObject tree = Instantiate(treePrefab, collision.contacts[0].point, Quaternion.identity);
            tree.GetComponent<Renderer>().material.color = Color.green; // Change the color of the tree
            Destroy(gameObject); // Destroy the bullet
            //Destroy(tree, bulletLifetime); // Destroy the tree after bulletLifetime seconds
        }
    }
}