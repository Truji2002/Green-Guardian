/*using System.Collections;
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
    public GameObject allowedPlane;

    void Update()
    {
        timer += Time.deltaTime; // Increment the timer by the time elapsed since the last frame

        if (Input.GetButton("Fire1") && timer >= fireRate)
        {
            Shoot();
            timer = 0f; // Reset the timer
        }
    }

    void Shoot(Collision collision)
    {
        float speed = maxDistance / bulletLifetime; // Calculate the speed required to travel the maximum distance in the given lifetime
        Rigidbody bullet = Instantiate(projectile, mySpawn.position, mySpawn.rotation);
        bullet.velocity = mySpawn.forward * speed; // Set the velocity of the bullet to the required speed
        bullet.GetComponent<Renderer>().material = seedMaterial; // Set the material of the bullet to the seed material
        //Destroy(bullet.gameObject, bulletLifetime); // Destroy the bullet after bulletLifetime seconds

        if (collision.gameObject.CompareTag("Plane"))
        {
            Destroy(bullet.gameObject, bulletLifetime);
        // La esfera ha colisionado con el plano
        // Agrega aquí el código que deseas ejecutar cuando la esfera toque el plano.
        }

    }*/
    

    
    

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
   
    public Rigidbody projectile;
    public Transform mySpawn;
    public float fireRate = 0.5f; // The time (in seconds) between shots
    public float bulletLifetime = 5f; // The time (in seconds) that bullets will exist before being destroyed
    public float maxDistance = 50f; // The maximum distance (in units) that bullets can travelx
    private float timer = 0f; // The timer that keeps track of the time elapsed
    public GameObject allowedPlane;

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
        Destroy(bullet.gameObject, bulletLifetime); // Destroy the bullet after bulletLifetime seconds
    }
}*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shooter : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform mySpawn;
    public float fireRate = 0.5f;
    public float bulletLifetime = 5f;
    public float maxDistance = 50f;
    public GameObject allowedPlane; // Objeto del plano permitido
    private float timer = 0f;

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

        // Desactivar la destrucción de la bala al colisionar con el plano permitido
        bullet.gameObject.AddComponent<NoDestroyOnCollision>();
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody bullet = Instantiate(projectile, mySpawn.position, mySpawn.rotation);
        // Si la bala choca con el plano permitido, desactivar la destrucción de la bala
        if (collision.gameObject == allowedPlane)
        {
            NoDestroyOnCollision noDestroy = collision.gameObject.GetComponent<NoDestroyOnCollision>();
            if (noDestroy != null && noDestroy.enabled)
            {
                Destroy(noDestroy);
            }

        }
        else
        {
         Destroy(bullet.gameObject, bulletLifetime);
        }
    }
}*/

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform mySpawn;
    public float fireRate = 0.5f;
    public float bulletLifetime = 5f;
    public float maxDistance = 50f;
    public GameObject allowedPlane; // Objeto del plano permitido
    private float timer = 0f;

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
        bullet.gameObject.tag = "Bullet"; // Añade el tag "Bullet"
        PlaneScript plane = allowedPlane.GetComponent<PlaneScript>();
        bullet.GetComponent<Renderer>().material.color = plane.bulletColor; // Asigna el color de la bala
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Shooter : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform mySpawn;
    public float fireRate = 0.5f;
    public float bulletLifetime = 5f;
    public float maxDistance = 50f;
   // public GameObject allowedPlane; // Objeto del plano permitido
    private float timer = 0f;
   public GameObject terrainObject;
   



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
    bullet.gameObject.tag = "Bullet"; // Añade el tag "Bullet"
    PlaneScript plane = allowedPlane.GetComponent<PlaneScript>();
    bullet.GetComponent<Renderer>().material.color = plane.bulletColor; //
   
   
    }


    
}*/


/*public class Shooter : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform mySpawn;
    public float fireRate = 0.5f;
    public float bulletLifetime = 5f;
    public float maxDistance = 50f;
    public GameObject allowedPlane; // Objeto del plano permitido
    private float timer = 0f;

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
        bullet.gameObject.tag = "Bullet"; // Añade el tag "Bullet"

        PlaneScript plane = allowedPlane.GetComponent<PlaneScript>();
        bullet.GetComponent<Renderer>().material.color = plane.bulletColor;
    }
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shooter : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform mySpawn;
    public float fireRate = 0.5f;
    public float bulletLifetime = 8f;
    public float maxDistance = 50f;
    public GameObject allowedPlane; // Objeto del plano permitido
    private float timer = 0f;
    public GameObject terrainObject;

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
        
        bullet.GetComponent<BulletController>().hitMaterial = GetComponent<MeshRenderer>().material; // Asigna el material actual de la bala al script BulletController
         Destroy(bullet.gameObject, bulletLifetime); // Destroy the bullet after bulletLifetime seconds
    }



}