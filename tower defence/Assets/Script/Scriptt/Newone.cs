using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newone : MonoBehaviour {
	public Rigidbody rb;
	public float moveSideways = 10000f;
	public float forwardforce = 10000f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce (0, 0, forwardforce * Time.deltaTime , ForceMode.VelocityChange );
		if (Input.GetKey ("d")) {
			rb.AddForce (moveSideways * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
		}
		if (Input.GetKey ("a")) {
			rb.AddForce (-moveSideways * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
		}
}
}