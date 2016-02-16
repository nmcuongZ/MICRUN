using UnityEngine;
using System.Collections;

public class UIPauseGame : MonoBehaviour {
	public GameObject camera;
	// Use this for initialization
	void Start () {
		camera.transform.position = GameObject.FindGameObjectWithTag ("MainCamera").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ResumeGame(){
		Time.timeScale = 1;
		Destroy (gameObject);
	}
}
