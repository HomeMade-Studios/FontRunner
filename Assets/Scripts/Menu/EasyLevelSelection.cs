using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EasyLevelSelection : MonoBehaviour {

	public GameObject highscore01, highscore02, highscore03, highscore04, highscore05;
	// Use this for initialization
	void Start () {
		highscore01.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore01").ToString();
		highscore02.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore02").ToString();
		highscore03.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore03").ToString();
		highscore04.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore04").ToString();
		highscore05.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore05").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Back ();
	}

	public void ToLevel01(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel02(){
		Application.LoadLevel ("Daidoh");
	}
	
	public void ToLevel03(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel04(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel05(){
		//Application.LoadLevel ("???");
	}
	
	public void Back(){
		Application.LoadLevel ("DifficultySelection");
	}
}
