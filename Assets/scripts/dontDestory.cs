﻿using UnityEngine;
using System.Collections;

public class dontDestory : MonoBehaviour {

	// Use this for initialization
	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}
}
