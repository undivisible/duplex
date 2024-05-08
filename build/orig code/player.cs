using UnityEngine;

public class Player : MonoBehaviour
{ 

	public float speed = 3.0f;

	// the gameobject to spawn the dot above.
	public GameObject target;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag("start");
		// spawn the dot above the target GameObject.
		transform.position = target.transform.position + new Vector3(0, 0, 1);
	}

	void Update()
	{
		// move the dot in the direction of the keyboard input.
		var movement = new Vector2(0, 0);
		if (Input.GetKey(KeyCode.W))
		{
			movement.y += 1;
		}
		if (Input.GetKey(KeyCode.A))
		{
			movement.x -= 1;
		}
		if (Input.GetKey(KeyCode.S))
		{
			movement.y -= 1;
		}
		if (Input.GetKey(KeyCode.D))
		{
			movement.x += 1;
		}

		// Move the dot by the amount of movement.
		transform.position += (Vector3)movement * speed * Time.deltaTime;
	}
}