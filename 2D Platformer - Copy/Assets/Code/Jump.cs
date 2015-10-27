using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float speed;
	private float frameSpeed;
	private bool currentlyJumping;
	private int jumpCounter;
	private float startingY;

	// Use this for initialization
	void Start () {
		frameSpeed = speed / 30.0f;
		currentlyJumping = false;
		jumpCounter = 0;
		startingY = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (currentlyJumping) {
			if(jumpCounter < 15) {
				float newY = gameObject.transform.position.y + frameSpeed;
				transform.position = new Vector3 (transform.position.x, newY, transform.position.z);
				jumpCounter++;                                
			}
			/*else if(jumpCounter < 30) {
				float newY = gameObject.transform.position.y - frameSpeed;
				if(newY > startingY)
					transform.position = new Vector3 (transform.position.x, newY, transform.position.z);
				jumpCounter++;
			}*/
			else {
				jumpCounter = 0;
				currentlyJumping = false;
			}
		}

		if (Input.GetKey (KeyCode.Space) && !currentlyJumping) {
			// start jump
			currentlyJumping = true;
			startingY = transform.position.y;
		}
	}
}
