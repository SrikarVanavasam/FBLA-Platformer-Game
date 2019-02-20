using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeManager : MonoBehaviour {

	Text time;

	// Use this for initialization
	void Start () {

		time = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {

		time.text = "" + Time.timeSinceLevelLoad;
	}
}
