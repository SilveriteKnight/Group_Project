using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raytraceGround : MonoBehaviour {

	public Rigidbody rb;
	public float hoverForce = 100;
	public float forwardForce = 10;

	void Start () 
	{
		rb = GetComponent<Rigidbody>();	
	}
	
	void FixedUpdate (){
		Vector3 forward = transform.TransformDirection (Vector3.up * -1) * 10;
		Debug.DrawRay (transform.position, forward, Color.green);
	
		RaycastHit hit;

		Ray ray = new Ray(transform.position, transform.up * -1);
		if (Physics.Raycast(ray, out hit)) 
		{
			print (hit.distance);
			rb.AddRelativeForce (Vector3.up * hoverForce/Mathf.Exp(hit.distance));
		}


		rb.AddRelativeTorque(Vector3.up*hoverForce*Input.GetAxis("Horizontal"));
		rb.AddRelativeTorque (Vector3.left * forwardForce * Input.GetAxis ("Vertical"));

	}


}
