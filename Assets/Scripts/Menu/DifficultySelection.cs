using UnityEngine;
using System.Collections;

public class DifficultySelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Back ();
	}

	public void ToEasyLevelSelection(){
		Application.LoadLevel ("EasyLevelSelection");
	}

	public void ToNormalLevelSelection(){
		Application.LoadLevel ("NormalLevelSelection");
	}

	public void ToHardLevelSelection(){
		Application.LoadLevel ("HardLevelSelection");
	}

	public void ToImpossibleLevelSelection(){
		Application.LoadLevel ("ImpossibleLevelSelection");
	}

	public void Back(){
		Application.LoadLevel ("MainMenu");
	}
}
