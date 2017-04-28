using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superBasicChase : MonoBehaviour {

	public Transform target;
	public Transform run;
	public bool trigger = false;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.LookAt(target);
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
	}
}
