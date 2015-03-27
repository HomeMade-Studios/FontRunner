using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathMenu : MonoBehaviour {

	public string levelDifficulty;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 
	}

	public void SetScore(int score, string levelCode){
		if(score > PlayerPrefs.GetInt("highscore" + levelCode)){
			transform.FindChild("New Highscore").gameObject.SetActive(true);
			PlayerPrefs.SetInt ("highscore" + levelCode, score);
		}
		transform.FindChild("Score").GetComponent<Text>().text = "Score: " + score.ToString();
		transform.FindChild ("High Score").GetComponent<Text>().text = "Highscore: " + PlayerPrefs.GetInt ("highscore" + levelCode).ToString ();
	}

	public void Retry() {
		Application.LoadLevel (Application.loadedLevelName);
	}

	public void ToLevelSelection() {
		switch (levelDifficulty) {
			case "Easy":
				Application.LoadLevel ("EasyLevelSelection");
				break;
			case "Normal":
				Application.LoadLevel ("NormalLevelSelection");
				break;
			case "Hard":
				Application.LoadLevel ("HardLevelSelection");
				break;
			case "Impossible":
				Application.LoadLevel ("ImpossibleLevelSelection");
				break;
		}
	}

	public void ToMainMenu() {
		Application.LoadLevel ("MainMenu");
	}


}
