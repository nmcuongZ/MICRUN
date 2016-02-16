using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour {
	private bool up = false, down = false;

	public int speed = 3;

	public Transform camera;

	public bool gravityState = false; // false mean gravity = 1, true mean gravity = -1

	bool isJumping = false;

	float heightScreen, widthScreen;

	Vector3 dir;

	// Use this for initialization
	void Start () {
		dir = new Vector3 (1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		Run ();
	}
		

	public void Run(){
		transform.position += dir * speed*Time.deltaTime;
	}

	void OnCollisionEnter2D(Collision2D col){

	}

	void OnCollisionExit2D(Collision2D col){
//		isFlying = true;
	}

	public void EndGame(){
		SceneManager.LoadScene ("EndGame");
	}

}
