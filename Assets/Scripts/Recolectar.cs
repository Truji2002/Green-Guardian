using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolectar : MonoBehaviour
{
  void OnCollisionEnter(Collision col)
    {

        if(col.gameObject.tag == "Basura")  
        {
            Destroy(col.gameObject); 
            //score.AddPoint(); 
        }
    }
}
