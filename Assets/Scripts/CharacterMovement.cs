using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	bool isJumping;
	public int jumpForce;
	GameController gameController;

	// Use this for initialization
	void Start () {
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		isJumping = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
				if(!isJumping){
					GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
					isJumping = true;
				}
		}
		if(Input.GetKeyDown(KeyCode.Space) && !isJumping){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
			isJumping = true;
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2 (0, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Ground") {
			isJumping = false;
		}
		if (other.gameObject.tag == "DeathZone") {
			gameController.Death();
			Destroy(this.gameObject);
		}
	}
}
