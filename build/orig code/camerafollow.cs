using UnityEngine;

public class camerafollow : MonoBehaviour
{
	public float rotationSpeed = 5f;
	public Transform target;
	public Vector3 offset;

	private float mouseX;
	private float mouseY;
	private float rotationX = 0f;
	private float rotationY = 0f;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

		if (target == null)
		{
			Debug.LogError("Camera target is not assigned!");
		}

		offset = transform.position - target.position;
	}

	private void Update()
	{
		mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
		mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

		rotationX -= mouseY;
		rotationX = Mathf.Clamp(rotationX, -90f, 90f);

		rotationY += mouseX;

		Quaternion rotation = Quaternion.Euler(rotationX, rotationY, 0f);
		Vector3 desiredPosition = target.position + rotation * offset;

		transform.rotation = rotation;
		transform.position = desiredPosition;
	}
}