using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletController : MonoBehaviour
{
    public Material hitMaterial; // Material con el color de la bala al tocar el plano
    public GameObject allowedPlane;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == allowedPlane) // Si la bala colisiona con el plano permitido
        {
            GetComponent<MeshRenderer>().material = hitMaterial; // Cambia el material de la bala al color deseado
        }
    }
}