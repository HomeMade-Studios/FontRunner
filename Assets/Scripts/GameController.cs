using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	
	public string levelCode;
	public GameObject deathMenu;
	public GameObject groundSection;
	GameObject scoreCounter, ground;
	public float groundSpeed;
	int score;
	bool isDead;

	// Use this for initialization
	void Start () {
		score = 0;
		isDead = false;
		ground = GameObject.FindGameObjectWithTag ("Ground");
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

	public void GroundSectionInstantiate(float groundPosition){
		GameObject instantiateObject = (GameObject)Instantiate (groundSection, new Vector3 (0, 0, 0), Quaternion.identity);
		instantiateObject.transform.SetParent (ground.GetComponent<Transform> ());
		instantiateObject.transform.localPosition = new Vector2 (6200, 0);
		instantiateObject.transform.localScale = new Vector3 (1, 1, 1);
	}
	
	public bool DeathCheck() {
		return isDead;
	}

	public void IncreaseGroundSpeed(){
		groundSpeed += 5;
	}

	public float GetGroundSpeed(){
		return groundSpeed; 
	}
}
