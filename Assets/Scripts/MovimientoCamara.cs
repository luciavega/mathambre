using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float minX, maxX, minY, maxY;

    float halfHeight;
    float halfWidth;

    void Start()
    {
        Camera cam = GetComponent<Camera>();
        halfHeight = cam.orthographicSize;
        halfWidth = halfHeight * cam.aspect;
    }

    void LateUpdate()
    {
        if (target == null) return;

        float desiredX = target.position.x;
        float desiredY = target.position.y;

        float clampedX = Mathf.Clamp(desiredX, minX + halfWidth, maxX - halfWidth);
        float clampedY = Mathf.Clamp(desiredY, minY + halfHeight, maxY - halfHeight);

        transform.position = new Vector3(clampedX, clampedY, -10f);
    }
}