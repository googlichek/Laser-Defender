using UnityEngine;

/// <summary>
/// Destroys objects on trigger collision.
/// </summary>
public class Shredder : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
