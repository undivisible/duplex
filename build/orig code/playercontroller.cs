using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 5f;

    private Rigidbody rb;
    private Transform mainCameraTransform;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCameraTransform = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Player Movement
        Vector3 movementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Vector3 cameraForward = mainCameraTransform.forward;
        cameraForward.y = 0f;
        Quaternion movementRotation = Quaternion.LookRotation(cameraForward);
        Vector3 movementDirection = movementRotation * movementInput;
        rb.velocity = movementDirection.normalized * movementSpeed;

        // Player Rotation
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        Quaternion additionalRotation = Quaternion.Euler(0f, mouseX, 0f);
        rb.MoveRotation(rb.rotation * additionalRotation);
    }

	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.tag == "door")
		{
			SceneManager.LoadScene(5);
			Debug.Log("Collided with the door!");
		}
	}
}