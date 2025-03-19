using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float respawnRange = 5f; // Adjust this value as needed

    public void GetBumped()
    {
        // Instead of destroying, move the object to a new random location
        Vector2 newPosition = new Vector2(
            Random.Range(-respawnRange, respawnRange),
            Random.Range(-respawnRange, respawnRange)
        );
        transform.position = newPosition;
    }
}

