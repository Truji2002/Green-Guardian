using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CambiarEscena : MonoBehaviour
{
    private bool canChangeScene = false;

    void Start()
    {
        StartCoroutine(EnableSceneChange());
    }

    IEnumerator EnableSceneChange()
    {
        yield return new WaitForSeconds(10f);
        canChangeScene = true;

        yield return new WaitForSeconds(0.1f); // Esperar un breve tiempo adicional

        // Cargar la escena "MenuInicial"
        SceneManager.LoadScene("MenuInicial");
    }

    void Update()
    {
        if (canChangeScene && Input.anyKeyDown)
        {
            StopAllCoroutines(); // Detener todas las corutinas en caso de que se presione una tecla antes de tiempo
            SceneManager.LoadScene("MenuInicial");

            // Restablecer la visibilidad y el bloqueo del cursor
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
