using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;

	void Start ()
	{
        var distance = transform.position.z - Camera.main.transform.position.z;
        var center = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, distance));
        var enemy = Instantiate(EnemyPrefab, center, Quaternion.identity) as GameObject;
	    enemy.transform.parent = transform;
	}
	
	void Update ()
    {
	}
}
