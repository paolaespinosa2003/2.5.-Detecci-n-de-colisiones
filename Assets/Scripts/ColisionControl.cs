using UnityEngine;

public class ColisionControl : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);

        // Ejemplo: si choca contra una pared, detener movimiento
        if (collision.gameObject.CompareTag("Pared"))
        {
            // Aquí se puede detener al personaje o cambiar estado
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
