using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	Transform mytransforamtion;
	public Vector3 direction;

	void Start () {
		direction = new Vector3 (1, 1, 0);
		mytransforamtion = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		mytransforamtion.localScale += new Vector3 (0.6f, 0.1f, 0.19f) * Time.deltaTime;
	}
}
