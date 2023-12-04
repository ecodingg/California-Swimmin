using UnityEngine;

public class MoveAwayFromPlayer : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    public float moveSpeed = 3f; // Speed at which the object moves away
    public float detectionDistance = 5f; // Distance at which the object starts moving away

    void Update()
    {
        // Check if the player reference is not null and is within detection distance
        if (player != null && Vector3.Distance(transform.position, player.transform.position) < detectionDistance)
        {
            Debug.Log("Fish too close");
            MoveAway();
        }
    }

    void MoveAway()
    {
        // Calculate the direction from the object to the player
        Vector3 directionToPlayer = transform.position - player.transform.position;

        // Normalize the direction vector to get a unit vector
        directionToPlayer.Normalize();

        // Calculate the target position away from the player
        Vector3 targetPosition = transform.position + directionToPlayer * moveSpeed * Time.deltaTime;

        // Move the object towards the target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
}
