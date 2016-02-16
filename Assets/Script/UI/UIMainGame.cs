using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIMainGame : MonoBehaviour {
	public Text scoreText;

	int score = 0;

	// Use this for initialization
	void Start () {
		StartCoroutine (ScoreUp ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PauseGame(){
		Time.timeScale = 0;
		Application.LoadLevelAdditive ("PauseScene");
	}

	IEnumerator ScoreUp(){
		while(true){
			yield return new WaitForSeconds(1);
			score += 1;
			scoreText.text = ""+score;
		}
	}
}
