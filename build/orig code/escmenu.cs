using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escmenu : MonoBehaviour
{
	public Image fadeImage;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			StartCoroutine(FadeOutAndExit());
		}
	}

	IEnumerator FadeOutAndExit()
	{
		float fadeTime = 4f;

		for (float i = 1; i >= 0; i -= 0.1f)
		{
			// fade to black
			Color color = fadeImage.color;
			color.a = i;
			fadeImage.color = color;
			yield return null;
		}

		// exit the game
		Application.Quit();
	}
}