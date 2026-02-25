using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioAutomaticoPorIndice : MonoBehaviour
{
    public float tiempoEspera = 5f; 
    public int indiceEscena = 1;    

    void Start()
    {
        Invoke("CambiarEscena", tiempoEspera);
    }

    void CambiarEscena()
    {
        SceneManager.LoadScene(indiceEscena);
    }
}