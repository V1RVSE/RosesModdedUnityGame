using UnityEngine;

public class ChasingEnemy : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.linearVelocity = direction * speed;  // Moves using physics
        }
    }
}
