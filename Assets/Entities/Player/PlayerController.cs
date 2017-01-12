using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Настраиваемая в Unity Editor скорость кораблика.
    public float ShipSpeed = 10f;

    private float _xMax;
    private float _xMin;
    private float _padding = 0.6f;

    void Start()
    {
        // Вычисление границ передвижения кораблей на экране.
        var distanceToCamera = transform.position.z - Camera.main.transform.position.z;
        var leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0 , 0, distanceToCamera));
        var rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceToCamera));
        _xMin = leftmost.x + _padding;
        _xMax = rightmost.x - _padding;
    }

	void Update ()
	{
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
}
