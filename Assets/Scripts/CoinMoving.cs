using UnityEngine;

public class FleeingObject : MonoBehaviour
{
    public Transform player; // Assign the white cube's Transform in the Inspector
    public float fleeSpeed = 1.5f;
    public float detectionRange = 3f; // Distance at which the yellow cube starts fleeing

    void Update()
    {
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.position);

            if (distance < detectionRange) // If the player gets too close
            {
                Vector3 direction = (transform.position - player.position).normalized;
                transform.position += direction * fleeSpeed * Time.deltaTime;
            }
        }
    }
}

