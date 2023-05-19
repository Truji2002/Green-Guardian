using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
//using TMPro;



public class DatosJugador : MonoBehaviour
{
    public int vidaPlayer;
    public Slider vidaVisual;
    public Vector3 posicion;
    public int muertes;

  

    void Start()
    {
        // Cargamos la posicion inicial desde un archivo JSON si existe
        string path = Application.persistentDataPath + "/posicion.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            posicion = JsonUtility.FromJson<Vector3>(json);
        }
        else
        {
            // Guardamos la posicion inicial en un archivo JSON
            posicion = transform.position;
            string json = JsonUtility.ToJson(posicion);
            File.WriteAllText(path, json);
        }

        // Reseteamos la vida y las muertes
        vidaPlayer = 100;
        muertes = 0;
    }

    void Update()
    {
        

        vidaVisual.GetComponent<Slider>().value = vidaPlayer;
        if (vidaPlayer <= 0)
        {
            muertes++;
            if (muertes < 2)
            {
                // Revivimos al jugador
                vidaPlayer = 100;
                transform.position = posicion;
            }
            else
            {
                Debug.Log(Application.persistentDataPath);

               SceneManager.LoadScene("Game Over");
            }
        }
        // Obtener el componente TextMeshPro del objeto Canvas
        //TextMeshProUGUI textoVidas = GetComponentInChildren<TextMeshProUGUI>();

        // Actualizar el texto con el número de vidas restantes
        //textoVidas.text = "Vidas restantes: " + (2 - muertes).ToString();
    }
       
}