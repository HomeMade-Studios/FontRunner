using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	bool isJumping;
	public int jumpForce;
	float jumpStart;
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
				GetComponent<Rigidbody2D>().gravityScale = 15;
				GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
				isJumping = true;
				jumpStart = Time.time;
			}
			else{
				if(Input.GetTouch(0).phase == TouchPhase.Ended || Time.time - jumpStart >= 0.8f)
					GetComponent<Rigidbody2D>().gravityScale = 40;
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
