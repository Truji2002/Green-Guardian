using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class CambiarEscena : MonoBehaviour
{
void Start()
{
StartCoroutine(EnableSceneChange());
}
IEnumerator EnableSceneChange()
{
    yield return new WaitForSeconds(10f);

    // Cargar la escena "MenuInicial"
    SceneManager.LoadScene("MenuInicial");
}
}