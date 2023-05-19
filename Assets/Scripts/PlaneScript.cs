using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    public Color bulletColor;
    public GameObject treePrefab;
    private bool treePlaced = false;



void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "Bullet")
    {
        Renderer renderer = other.GetComponent<Renderer>();
        if (renderer != null)
        {
            // Cambiar el color de la bala
            renderer.material.color = bulletColor;
            // Agregar registro para verificar la detección de colisión
            Debug.Log("Colisión detectada");

            // Llamar al método PlaceTree con la posición de la bala que colisionó con el plano
            PlaceTree(other.transform.position);
            Destroy(other.gameObject);
        }
    }
}




void PlaceTree(Vector3 position)
{
    // Instanciar prefab del árbol en la posición especificada
    Instantiate(treePrefab, position, Quaternion.identity);
}





}