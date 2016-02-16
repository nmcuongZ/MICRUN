using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {
	bool stop = false;
	// Use this for initialization
	void Start () {
		StartCoroutine (TestCoroutine());
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0))
			stop = true;
	}

	IEnumerator TestCoroutine(){
		float seconds = 0;
		Debug.Log ("Start at : " + (float)Time.time);
		while (seconds < 10f) {
			seconds += Time.deltaTime;
			Debug.Log ("Time : " + Time.time);
			yield return null;
			if (stop) {
				Debug.Log ("Stop");
				return true;
			}
		}
			
		Debug.Log ("Finish at : " + (float)Time.time);

	}
}
