using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Speed of the ship. Adjustable in Unity Editor.
    public float ShipSpeed = 10f;
    public GameObject Projectile;
    public float ProjectileSpeed;
    public float FireRate;

    private float _xMax;
    private float _xMin;
    private float _padding = 0.6f;

    void Start()
    {
        // Calculations of ship movement boundaries.
        var distanceToCamera = transform.position.z - Camera.main.transform.position.z;
        var leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0 , 0, distanceToCamera));
        var rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceToCamera));
        _xMin = leftmost.x + _padding;
        _xMax = rightmost.x - _padding;
    }

	void Update ()
	{
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("Fire", 0.000001f, FireRate);
        }

	    if (Input.GetKeyUp(KeyCode.Space))
	    {
	        CancelInvoke("Fire");
	    }

        if (Input.GetKey(KeyCode.LeftArrow))
	    {
	        transform.position += Vector3.left * ShipSpeed * Time.deltaTime;
	        var newX = Mathf.Clamp(transform.position.x, _xMin, _xMax);
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
	    }
	    else if (Input.GetKey(KeyCode.RightArrow))
	    {
            transform.position += Vector3.right  * ShipSpeed * Time.deltaTime;
            var newX = Mathf.Clamp(transform.position.x, _xMin, _xMax);
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
	}

    private void Fire()
    {
        var beam = Instantiate(Projectile, transform.position, Quaternion.identity) as GameObject;
        beam.GetComponent<Rigidbody2D>().velocity = new Vector3(0, ProjectileSpeed, 0);
    }
}
