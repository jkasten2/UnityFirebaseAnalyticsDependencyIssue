using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirebaseLogEventTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Log an event with no parameters.
		Firebase.Analytics.FirebaseAnalytics
		  .LogEvent(Firebase.Analytics.FirebaseAnalytics.EventLogin);

		// Log an event with a float parameter
		Firebase.Analytics.FirebaseAnalytics
		  .LogEvent("progress2", "percent", 0.4f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
