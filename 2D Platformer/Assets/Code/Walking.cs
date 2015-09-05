using UnityEngine;
using System.Collections;

public class Walking : MonoBehaviour {

	public float speed;
	private Rigidbody2D maple;

	// Use this for initialization
	void Start () {
		maple = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		//transform.position = new Vector3 (newX, transform.position.y, transform.position.z);

		if (Input.GetKey (KeyCode.RightArrow)) {
			float newX = gameObject.transform.position.x + speed;
			transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			float newX = gameObject.transform.position.x - speed;
			transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
		}
		maple.AddForce(Vector2.right * speed);
	}
}
