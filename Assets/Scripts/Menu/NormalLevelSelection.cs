using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NormalLevelSelection : MonoBehaviour {

	public GameObject highscore01, highscore02, highscore03, highscore04, highscore05;
	// Use this for initialization
	void Start () {
		highscore01.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore11").ToString();
		highscore02.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore12").ToString();
		highscore03.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore13").ToString();
		highscore04.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore14").ToString();
		highscore05.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore15").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Back ();
	}

	public void ToLevel11(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel12(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel13(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel14(){
		//Application.LoadLevel ("???");
	}
	
	public void ToLevel15(){
		//Application.LoadLevel ("???");
	}
	
	public void Back(){
		Application.LoadLevel ("DifficultySelection");
	}
}
