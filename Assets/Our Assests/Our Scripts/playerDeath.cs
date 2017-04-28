using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerDeath : MonoBehaviour {

    public float health = 100;
    public float damageTake = 34;
    public GameObject damageDealer;
    private Rigidbody hitTaker;
    public float throwSpeed = 25000;

	// Use this for initialization
	void Start () {
		hitTaker = damageDealer.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        print(collision.collider.name);
        if (collision.collider.name == "Hit")
        {
            health = health - damageTake;
            hitTaker.AddForce(Vector3.back * throwSpeed);

            if (health <= 0)
            {
                Application.Quit();
            }
        }
    }
}
