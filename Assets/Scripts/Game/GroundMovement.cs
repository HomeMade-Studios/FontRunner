using UnityEngine;
using System.Collections;

public class GroundMovement : MonoBehaviour {
	
	GameController gameController;
	// Use this for initialization
	void Start () {
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameController.DeathCheck ())
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-gameController.GetGroundSpeed(), 0);
		else 
			if(GetComponent<Rigidbody2D> ().velocity.x < 0){
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x + 1, 0);
			}
	}
}
