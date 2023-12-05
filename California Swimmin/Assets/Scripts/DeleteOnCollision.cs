using UnityEngine;

public class DeleteOnCollision : MonoBehaviour
{

    public DisplayText textBox;
    public string fishText;
    public fishCollection fishy;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            //Delete gameobject
            Debug.Log("Player Detected");
            Destroy(gameObject);
            textBox.fishInfo(fishText);
            fishy.collectFish(1);
        }
    }
}
