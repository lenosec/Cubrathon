using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR : MonoBehaviour {
	public Rigidbody rb;
	public float forwardForce = 200f;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		rb.AddForce(0,0,-forwardForce * Time.deltaTime, ForceMode.VelocityChange);
	}
}
