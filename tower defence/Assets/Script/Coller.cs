
using UnityEngine;

public class Coller : MonoBehaviour {
	public Newone movement;
	void OnCollisionEnter(Collision info){
		if(info.collider.tag == "obsticle"){
			Debug.Log("WheelHit out");
			movement.enabled = false;
	}
}
}