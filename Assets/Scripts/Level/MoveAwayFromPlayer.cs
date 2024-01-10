using UnityEngine;

public class MoveAwayFromPlayer : MonoBehaviour
{
    public Transform playerTransform; // Player's transform
    public float moveRadius = 5.0f; // Radius within which the object moves away
    public float moveSpeed = 5.0f; // Speed at which the object moves away

    private Vector3 originalPosition; // To store the object's original position

    void Start()
    {
        originalPosition = transform.position; // Store the original position
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);

        if (distanceToPlayer < moveRadius)
        {
            // Calculate direction from the object to the player
            Vector3 directionFromPlayer = transform.position - playerTransform.position;
            directionFromPlayer.Normalize();

            // Move the object away from the player
            transform.position += directionFromPlayer * moveSpeed * Time.deltaTime;
        }
        else
        {
            // Optionally, return the object to its original position when the player is far enough
            transform.position = Vector3.MoveTowards(transform.position, originalPosition, moveSpeed * Time.deltaTime);
        }
    }
}
