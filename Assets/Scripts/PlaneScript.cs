using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    public Color bulletColor;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


  /* void OnTriggerEnter(Collider other)
{
    if (other.tag == "Bullet")
    {
        Renderer renderer = other.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = bulletColor;
        }
    }
}*/


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
        }
    }
}

}





