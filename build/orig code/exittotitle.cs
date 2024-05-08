using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exittotitle : MonoBehaviour
{
	public string SceneName;
	public float holdTime = 1f; // time in seconds to hold the escape key

	private bool isEscapeHeld = false;
	private float timer = 0f;

	private void Update()
	{
		// check if the escape key is being held
		if (Input.GetKey(KeyCode.Escape))
		{
			timer += Time.deltaTime;

			// check if the escape key has been held for the specified holdTime
			if (timer >= holdTime && !isEscapeHeld)
			{
				isEscapeHeld = true;

				// load the title scene
				SceneManager.LoadScene(SceneName);
			}
		}
		else
		{
			// Reset the timer if the Escape key is released
			isEscapeHeld = false;
			timer = 0f;
		}
	}
}