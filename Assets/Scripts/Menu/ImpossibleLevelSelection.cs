using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImpossibleLevelSelection : MonoBehaviour {

	public GameObject highscore01, highscore02, highscore03, highscore04, highscore05;
	// Use this for initialization
	void Start () {
		highscore01.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore31").ToString();
		highscore02.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore32").ToString();
		highscore03.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore33").ToString();
		highscore04.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore34").ToString();
		highscore05.GetComponent<Text>().text = PlayerPrefs.GetInt ("highscore35").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Back ();
	}

	public void ToLevel31(){
		//Application.LoadLevel ("???");
	}

	public void ToLevel32(){
		//Application.LoadLevel ("???");
	}

	public void ToLevel33(){
		//Application.LoadLevel ("???");
	}

	public void ToLevel34(){
		//Application.LoadLevel ("???");
	}

	public void ToLevel35(){
		//Application.LoadLevel ("???");
	}

	public void Back(){
		Application.LoadLevel ("DifficultySelection");
	}
}
