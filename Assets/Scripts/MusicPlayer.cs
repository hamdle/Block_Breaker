﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;

	// Use this for initialization
	void Start () {
		if (instance != null)
		{
			Destroy(gameObject);
			print("Duplicate music player destoryed");
		}
		else
		{
			// First!
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
}
