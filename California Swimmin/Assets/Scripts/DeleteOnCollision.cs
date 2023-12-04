using UnityEngine;

public class DeleteOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // If it is the player, destroy this game object
            Destroy(gameObject);
        }
    }
}
