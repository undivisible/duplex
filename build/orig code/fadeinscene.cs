using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeinscene : MonoBehaviour
{
	public float seconds = 1.0f;
	public string sceneName = "title";

	void Start()
	{
		StartCoroutine(LoadSceneAfterDelay());
	}

	private IEnumerator LoadSceneAfterDelay()
	{
		yield return new WaitForSeconds(seconds);
		SceneManager.LoadScene(sceneName);
	}
}