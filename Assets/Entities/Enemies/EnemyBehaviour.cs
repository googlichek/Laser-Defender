using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float Health = 150f;

    void OnTriggerEnter2D(Collider2D collider)
    {
        var beam = collider.gameObject.GetComponent<Projectile>();
        if (beam)
        {
            Health -= beam.GetDamage();
            beam.Hit();
            if (Health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
