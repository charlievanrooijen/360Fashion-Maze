using UnityEngine;

public class MirrorCamera : MonoBehaviour
{
    public Transform playerCamera; // Reference to the player's camera

    void LateUpdate()
    {
        // Rotation: Mirrored rotation
        Vector3 dirToPlayer = transform.position - playerCamera.position;
        Vector3 reflectedDir = Vector3.Reflect(dirToPlayer, Vector3.up);
        transform.rotation = Quaternion.LookRotation(reflectedDir);
    }
}
