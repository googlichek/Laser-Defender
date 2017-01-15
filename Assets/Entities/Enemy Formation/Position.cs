using UnityEngine;

/// <summary>
/// Helper class for drawing enemy position gizmos.
/// </summary>
public class Position : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 1);
    }
}
