using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 100.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Rotation
        float rotationHorizontal = Input.GetAxis("Mouse X") + Input.GetAxis("RightJoystickHorizontal"); // Mouse and Right Joystick
        float rotation = rotationHorizontal * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, rotation, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);

        // Movement
        float moveHorizontal = Input.GetAxis("Horizontal"); // AD / Left Joystick left right
        float moveVertical = Input.GetAxis("Vertical"); // WS / Left Joystick up down
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement = rb.rotation * movement; // Rotate the movement vector by the player's current rotation

        Vector3 newPosition = rb.position + movement * movementSpeed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }
}
