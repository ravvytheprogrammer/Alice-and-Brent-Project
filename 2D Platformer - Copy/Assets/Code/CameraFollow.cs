using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public Transform myPlay;
	private Vector3 myPos;

	// Use this for initialization
	void Start () {
		myPos = new Vector3 (-0.14f, -2.4f, -10f);
		myPos -= myPlay.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = myPlay.position + myPos;
	}
}
