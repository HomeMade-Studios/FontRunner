using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HardLevelSelection : MonoBehaviour {

	public GameObject highscore01, highscore02, highscore03, highscore04, highscore05;
	// Use this for initialization
	void Start () {
		highscore01.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore21").ToString();
		highscore02.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore22").ToString();
		highscore03.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore23").ToString();
		highscore04.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore24").ToString();
		highscore05.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore25").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Back ();
	}

	public void ToLevel21(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel22(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel203(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel24(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel25(){
		//Application.LoadLevel ("???");
	}
	
	public void Back(){
		Application.LoadLevel ("DifficultySelection");
	}
}
