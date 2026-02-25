using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioAutomatico : MonoBehaviour
{
    public float tiempoEspera = 5f; 
    public string nombreEscena = "Escena1"; 

    void Start()
    {
        StartCoroutine(CambiarEscenaDespuesDeTiempo());
    }

    private System.Collections.IEnumerator CambiarEscenaDespuesDeTiempo()
    {
        yield return new WaitForSeconds(tiempoEspera);
        SceneManager.LoadScene(nombreEscena);
    }
}