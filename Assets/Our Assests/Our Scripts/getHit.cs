using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHit : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if (col.name == "Sphere(Clone)") {
			GetComponentInParent<basicChase> ().setFleeing ();
		}
	}
}
