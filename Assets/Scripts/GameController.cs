using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	bool isDead;
	public string levelCode;
	public GameObject deathMenu;
	GameObject scoreCounter;
	int score;
	// Use this for initialization
	void Start () {
		score = 0;
		isDead = false;
		scoreCounter = GameObject.FindGameObjectWithTag ("Score");
		scoreCounter.GetComponent<Text> ().text = "0";
		InvokeRepeating ("IncreaseScore", 1f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void IncreaseScore() {
		if (!isDead) {
			score++;
			scoreCounter.GetComponent<Text> ().text = score.ToString ();
		}
		else
			CancelInvoke();
	}

	public void Death() {
		isDead = true;
		deathMenu.SetActive(true);
		deathMenu.GetComponent<DeathMenu>().SetScore (score, levelCode);
	}
	
	public bool DeathCheck() {
		return isDead;
	}
}
