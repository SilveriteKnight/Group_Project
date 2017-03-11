using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour {

	public GameObject target;
	public float xCorrection = 0;
	public float zCorrection = -8;
	public float yCorrection = -1;
	public float lerpSpeed = 1;


	void FixedUpdate (){
		Vector3 moveTarget = new Vector3 (target.transform.position.x + xCorrection,target.transform.position.y + yCorrection,target.transform.position.z + zCorrection);
		transform.position = Vector3.Lerp (transform.position, moveTarget, Time.deltaTime * lerpSpeed);
	}

}
