using UnityEngine;

public class FormationController : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float Width  = 11f;
    public float High = 5f;
    public float EnemySpeed = 3f;
    public float SpwanDelay = 0.5f;

    private bool _movingRight = true;
    private float _xMax;
    private float _xMin;
    private float _padding = 0.6f;

    void Start ()
    {
        CalculateEdges();
        FillEmptyPositions();
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(Camera.main.transform.position, new Vector3(Width, High));
    }

    void Update ()
    {
        if (_movingRight)
	    {
	        transform.position += Vector3.right * EnemySpeed * Time.deltaTime;
	    }
	    else
	    {
            transform.position += Vector3.left * EnemySpeed * Time.deltaTime;
        }

        // Edge positions of enemy an ship swarm movement.
        var rightEdgeOfFormation = transform.position.x + 0.5f * Width;
        var leftEdgeOfFormation = transform.position.x - 0.5f * Width;

        if (leftEdgeOfFormation < _xMin + _padding)
        {
            _movingRight = true;
        }
        else if (rightEdgeOfFormation > _xMax - _padding)
        {
            _movingRight = false;
        }

        if (AllMembersDead())
        {
            FillEmptyPositions();
        }
    }

    // Fills empty positions in formation with enemy ships.
    private void FillEmptyPositions()
    {
        var freePosition = GetNextFreePosition();
        if (freePosition)
        {
            var enemy = Instantiate(EnemyPrefab, freePosition.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = freePosition;
        }

        if (GetNextFreePosition())
        {
            Invoke("FillEmptyPositions", SpwanDelay);
        }
    }

    private Transform GetNextFreePosition()
    {
        foreach (Transform childPositionGameObject in transform)
        {
            if (childPositionGameObject.childCount == 0)
            {
                return childPositionGameObject;
            }
        }

        return null;
    }

    // Checks wether all enemy ship objects are destroyed.
    private bool AllMembersDead()
    {
        foreach (Transform childPositionGameObject in transform)
        {
            if (childPositionGameObject.childCount > 0)
            {
                return false;
            }
        }

        return true;
    }

    // Calculates boundaries of game space.
    private void CalculateEdges()
    {
        var distanceToCamera = transform.position.z - Camera.main.transform.position.z;
        var leftEdge = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceToCamera));
        var rightEdge = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceToCamera));

        _xMax = rightEdge.x;
        _xMin = leftEdge.x;
    }
}
