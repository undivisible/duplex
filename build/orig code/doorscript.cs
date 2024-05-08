using UnityEngine;
using UnityEngine.SceneManagement;

public class doorscript : MonoBehaviour
{
	public string sceneName; // The name of the scene to transition to

	private bool hasTriggered = false; // Flag to prevent multiple triggers

	private void Update()
	{
		if (Input.GetMouseButtonDown(0) && !hasTriggered)
		{
			// Check if the mouse click hits the door
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider.gameObject == gameObject)
				{
					hasTriggered = true;
					SceneManager.LoadScene(sceneName);
					Debug.Log("Door triggered by mouse click.");
				}
			}
		}
	}

}