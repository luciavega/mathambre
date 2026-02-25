using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movimiento = new Vector2(moveX, moveY).normalized;

        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}