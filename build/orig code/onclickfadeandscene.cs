using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class onclickfadeandscene : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			SceneManager.LoadScene(3);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			SceneManager.LoadScene(4);
		}
	}
}