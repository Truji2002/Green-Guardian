using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform target; // Referencia al Transform del jugador (First Person Controller)
    public float moveSpeed = 5f; // Velocidad de movimiento del enemigo

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (target != null)
        {
            // Calcula la dirección hacia el jugador
            Vector3 direction = (target.position - transform.position).normalized;

            // Aplica una fuerza para mover al enemigo en la dirección calculada
            rb.velocity = direction * moveSpeed * Time.fixedDeltaTime;
        }
    }
}