﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscBtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Escape)){

			Debug.Log ("sfd");
			Application.Quit();
			Debug.Log ("ggg");
		}
		
	}
}