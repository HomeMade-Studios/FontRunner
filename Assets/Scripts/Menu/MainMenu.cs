using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GameObject mainMenu, exitConfirm;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (!exitConfirm.activeSelf)
				OpenExitConfirm ();
			else
				CloseExitConfirm ();
		}

	}

	public void ToLevelSelection(){
		if(!exitConfirm.activeSelf)
			Application.LoadLevel ("DifficultySelection");
	}

	public void ToOptions(){
		if(!exitConfirm.activeSelf)
			Application.LoadLevel ("Options");
	}

	public void ToFontShop(){
		if(!exitConfirm.activeSelf)
			Application.LoadLevel ("FontShop");
	}

	public void ToLeaderboards(){
		if(!exitConfirm.activeSelf)
			Application.LoadLevel ("Leaderboards");
	}

	public void OpenExitConfirm(){
		exitConfirm.SetActive (true);
		//mainMenu.GetComponent<Image> ().color.a = 150f;
	}

	public void CloseExitConfirm(){
		exitConfirm.SetActive (false);
		//mainMenu.GetComponent<Image> ().color.a = 255f;
	}

	public void Quit(){
		Application.Quit ();
	}	
}
