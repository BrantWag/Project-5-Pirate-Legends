﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	public void StartGame ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);//lods next scene in the index
	}
}