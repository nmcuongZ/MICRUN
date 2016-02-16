using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	private static float startCameraPos;
	Transform Player;
	float yPos;
	// Use this for initialization
	void Start () {
		yPos = transform.position.y;
//		transform.position = playerTranform.position;
        Player = GameObject.FindGameObjectWithTag("hero").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Player.position.x, transform.position.y, -10);
	}
}
