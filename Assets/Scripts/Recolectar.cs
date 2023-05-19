using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolectar : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;

    [SerializeField] private Puntaje puntaje;

  void OnCollisionEnter(Collision col)
    {

        if(col.gameObject.tag == "Basura")  
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(col.gameObject); 
            
        }
    }
}
