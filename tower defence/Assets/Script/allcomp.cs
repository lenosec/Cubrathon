using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allcomp : MonoBehaviour {
	/*

	public Transform mytrans;
	orrr
	*/
	public Light seenLight;
	GameObject myobj;
	Transform myTrans;

	void Start () {
		myobj = GetComponent<GameObject> ();
		myTrans = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		myTrans.position += Vector3.forward * Time.deltaTime;
			seenLight.intensity -= 0.005f ;
	}
}
