using UnityEngine;
using System.Collections;

public class Walking : MonoBehaviour {

	public float speed;
	private GameObject playerAnimation;
	private Rigidbody2D maple;
	private Animator animator;

	// Use this for initialization
	void Start () {
		playerAnimation = gameObject.transform.GetChild(0).gameObject;
		maple = gameObject.GetComponent<Rigidbody2D>();
		animator = playerAnimation.GetComponent<Animator>();        
	}
	
	// Update is called once per frame
	void Update () {
		var isFalling = (int) maple.velocity.y != 0;

		if (isFalling)
			animator.SetBool("grounded", false);
		else
			animator.SetBool("grounded", true);

		if (Input.GetKey (KeyCode.RightArrow) && !isFalling) {
			float newX = gameObject.transform.position.x + speed;
			transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
		}

		if (Input.GetKey (KeyCode.LeftArrow) && !isFalling) {
			float newX = gameObject.transform.position.x - speed;
			transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
		}
		maple.AddForce(Vector2.right * speed);
	}
}