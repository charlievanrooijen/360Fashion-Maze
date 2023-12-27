using UnityEngine;
using System.Collections.Generic;

public class MovingPlatform : MonoBehaviour
{
    public List<Transform> waypoints; // List of all waypoints
    public float speed = 2.0f; // Speed at which the platform moves
    private int targetWaypointIndex = 0; // Index of the waypoint where the platform is moving to
    private Transform targetWaypoint; // Current target waypoint

    void Start()
    {
        if (waypoints.Count > 0)
        {
            targetWaypoint = waypoints[targetWaypointIndex]; // Set the initial target waypoint
        }
    }

    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        if (targetWaypoint != null)
        {
            // Move the platform towards the target waypoint
            transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

            // Check if the platform has reached the target waypoint
            if (transform.position == targetWaypoint.position)
            {
                targetWaypointIndex++; // Set the next waypoint as the target
                if (targetWaypointIndex >= waypoints.Count)
                {
                    targetWaypointIndex = 0; // Loop back to the start
                }
                targetWaypoint = waypoints[targetWaypointIndex];
            }
        }
    }
}
