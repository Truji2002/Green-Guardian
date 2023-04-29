using System.Collections;
using System.Collections.Generic;
using UnityEngine;


   public class NoDestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Desactivar la destrucción en colisión de la bala
        Destroy(this);
    }
}

