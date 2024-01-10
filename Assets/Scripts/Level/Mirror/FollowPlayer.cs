using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform; // The player's transform

    void LateUpdate()
    {
        // Rotate the camera to always look at the player
        transform.LookAt(playerTransform);
    }
}
