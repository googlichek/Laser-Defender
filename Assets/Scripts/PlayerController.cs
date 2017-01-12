using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Настраиваемая в Unity Editor скорость кораблика.
    public float ShipSpeed = 7.5f;

	void Update ()
	{
	    if (Input.GetKey(KeyCode.LeftArrow))
	    {
	        var shipPosition = new Vector3(
                transform.position.x - ShipSpeed * Time.deltaTime, transform.position.y, 0f);
            shipPosition.x = Mathf.Clamp(shipPosition.x, 0.5f, 15.5f);
	        transform.position = shipPosition;
	    }
	    else if (Input.GetKey(KeyCode.RightArrow))
	    {
            var shipPosition = new Vector3(
                transform.position.x + ShipSpeed * Time.deltaTime, transform.position.y, 0f);
            shipPosition.x = Mathf.Clamp(shipPosition.x, 0.5f, 15.5f);
            transform.position = shipPosition;
        }
	}
}
