using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagedObject : MonoBehaviour {

	public float life = 100;

	// Use this for initialization
	void Start () {

	}

	void OnCollisionEnter(Collision collision)
	{
		print(collision.collider.name);
		if(collision.collider.name != "Terrain")
		{
			life -= collision.collider.GetComponent<damageValue>().getDamage();
		}
		if(life < 0)
		{
			Destroy(gameObject);
		}
	}
}