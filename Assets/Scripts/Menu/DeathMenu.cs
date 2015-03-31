using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathMenu : MonoBehaviour {
	
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
		Application.LoadLevel ("LevelSelection");
	}

	public void ToMainMenu() {
		Application.LoadLevel ("MainMenu");
	}


}
