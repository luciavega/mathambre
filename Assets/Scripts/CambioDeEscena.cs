using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    public float tiempoEspera = 5f; 
    public int indiceEscena = 1; 

    void Start()
    {
        StartCoroutine(CambioDeEscenaCoroutine());
    }

    private System.Collections.IEnumerator CambioDeEscenaCoroutine()
    {
        yield return new WaitForSeconds(tiempoEspera);
        SceneManager.LoadScene(indiceEscena);
    }
}