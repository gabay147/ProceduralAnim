using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	private Rigidbody rb;
	private Collider collider;
	public float speed;
	public float curVelocity;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		collider = GetComponent<Collider> ();
	}
	
	// Update is called once per frame
	void Update () {
		float inputZ = Input.GetAxisRaw ("Vertical");
		float inputX = Input.GetAxisRaw ("Horizontal");
		Vector3 deltaForce = new Vector3 (inputX, 0.0f, inputZ);
		rb.AddForce (deltaForce * speed, ForceMode.Impulse);
		curVelocity = rb.velocity.magnitude;
	}
}
