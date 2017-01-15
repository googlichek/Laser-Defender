using UnityEngine;

/// <summary>
/// Describes projectile & it's capabilities.
/// </summary>
public class Projectile : MonoBehaviour
{
    public float Damage = 100f;

    public float GetDamage()
    {
        return Damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }
}
