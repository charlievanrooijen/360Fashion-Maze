using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public bool isOpening = false;
    public float openSpeed = 1.0f;
    public Vector3 openDirection = Vector3.down; // Assuming the door opens by moving downwards
    public float openDistance = 3.0f; // How far the door moves
    private Vector3 originalPosition;
    private Vector3 openPosition;

    void Start()
    {
        originalPosition = transform.position;
        openPosition = originalPosition + (openDirection.normalized * openDistance);
    }

    void Update()
    {
        if (isOpening)
        {
            transform.position = Vector3.MoveTowards(transform.position, openPosition, openSpeed * Time.deltaTime);
        }
    }

    public void OpenDoor()
    {
        isOpening = true;
    }
}
