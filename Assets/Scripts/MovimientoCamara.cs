using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public float suavizado = 0.1f; 

    public float minX, maxX, minY, maxY;

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 posDeseada = new Vector3(target.position.x, target.position.y, transform.position.z);

        posDeseada.x = Mathf.Clamp(posDeseada.x, minX, maxX);
        posDeseada.y = Mathf.Clamp(posDeseada.y, minY, maxY);

        transform.position = Vector3.SmoothDamp(transform.position, posDeseada, ref velocity, suavizado);
    }
}