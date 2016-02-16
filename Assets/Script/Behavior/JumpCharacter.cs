using UnityEngine;
using System.Collections;

public class JumpCharacter : MonoBehaviour {

    public float high = 2.5f; // limit high character can reach

    bool isJumping = false;

    Vector3 startPos;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            if (!isJumping) {
                startPos = transform.position;
  //              SetJump(true);
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
            }
        }
	}

    void SetJump(bool jumpState) {
        isJumping = jumpState;
    }
}
