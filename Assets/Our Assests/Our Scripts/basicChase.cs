using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicChase : MonoBehaviour {

	public Transform chase;
	public Transform run;
	public bool chasing = false;
	public bool fleeing = false;
	public float chaseSpeed;
    public float runSpeed;
	private Vector3 turn;
    public float deathTime;

	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter (Collider other){
		if(fleeing == false && other.name == "FPSController"){
			chasing = true;
		}
	}

	/*void OnCollisionEnter (Collision collider){
		if(collision.collider.name == "Sphere(Clone)"){
			transform.Rotate (180, 0, 0);
		}
	}*/

	void Update () {
		if(chasing){
			transform.LookAt(chase);
			float step = chaseSpeed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, chase.position, step);
		}
		if (fleeing) {
            transform.LookAt(run);
			float step = runSpeed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, run.position, step);
            Destroy(gameObject, deathTime);
		}
	}

	public void setFleeing(){
		fleeing = true;
		chasing = false;
	}

	void OnCollisionEnter(Collision collision){
		print (collision.collider.name);
			
		if(collision.collider.name == "Snowball(Clone)"){
			chasing = false;
			fleeing = true;
			/*transform.LookAt (run);
			float step = (speed + 3) * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, run.position, step);*/
		}
	}
}
