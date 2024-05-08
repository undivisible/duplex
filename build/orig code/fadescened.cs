using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadescened : MonoBehaviour
{
	public float seconds = 1.0f;
	public string sceneName = "duplex";

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