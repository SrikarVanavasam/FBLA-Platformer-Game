using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealLeaderboard : MonoBehaviour {

	dreamloLeaderBoard dl;

	// Use this for initialization
	void Start () {
		// get the reference here...
		this.dl = dreamloLeaderBoard.GetSceneDreamloLeaderboard();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		GUILayoutOption[] width200 = new GUILayoutOption[] { GUILayout.Width (200) };

		float width = 400;  // Make this wider to add more columns
		float height = 200;

		Rect r = new Rect ((Screen.width / 2) - (width / 2), (Screen.height / 2) - (height), width, height);
		GUILayout.BeginArea (r, new GUIStyle ("box"));

		GUILayout.BeginVertical ();


		GUILayout.Label ("High Scores:");
		List<dreamloLeaderBoard.Score> scoreList = dl.ToListHighToLow ();

		if (scoreList == null) {
			GUILayout.Label ("(loading...)");
		} else {
			int maxToDisplay = 20;
			int count = 0;
			foreach (dreamloLeaderBoard.Score currentScore in scoreList) {
				count++;
				GUILayout.BeginHorizontal ();
				GUILayout.Label (currentScore.playerName, width200);
				GUILayout.Label (currentScore.score.ToString (), width200);
				GUILayout.EndHorizontal ();

				if (count >= maxToDisplay)
					break;
			}
		}



	}
}
