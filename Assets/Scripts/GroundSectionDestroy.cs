using UnityEngine;
using System.Collections;

public class GroundSectionDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -1800)
			Destroy (this.gameObject);
	}
}
