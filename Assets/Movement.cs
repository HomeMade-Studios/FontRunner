using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	bool isJumping;
	public int jumpForce, speed;
	// Use this for initialization
	void Start () {
		isJumping = false;
		GetComponent<Rigidbody2D>().velocity = new Vector2 (speed, GetComponent<Rigidbody2D>().velocity.y);
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
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Ground") {
			isJumping = false;
		}
	}
}
