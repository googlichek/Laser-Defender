using UnityEngine;

// Destroys objects on trigger collision. 
public class Shredder : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
