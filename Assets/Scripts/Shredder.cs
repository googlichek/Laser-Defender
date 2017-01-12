using UnityEngine;

// Уничтожает объекты, с которыми вступает во взаимодействие.
public class Shredder : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
