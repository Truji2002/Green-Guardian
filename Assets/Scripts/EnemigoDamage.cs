using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDamage : MonoBehaviour
{
    // Start is called before the first frame update
  public int damage;
  public GameObject Player;
  public GameObject Player1;

  private void OnTriggerEnter(Collider other) {
    
    if(other.tag == "Player")
    {
        Player.GetComponent<DatosJugador>().vidaPlayer -= damage;
        Player1.GetComponent<DatosJugador>().vidaPlayer -= damage;
    }

     if(other.tag == "Enemigo")
    {
        Debug.Log("Esto es un enemigo");

    }

}

}