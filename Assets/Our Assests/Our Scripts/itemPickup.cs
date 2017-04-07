using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPickup : MonoBehaviour {

    public bool ConsumeItem = false;
    public Collider itemGrab;
    //public float itemMid;
    public float itemRadius = 5;

	// Use this for initialization
	void Start () {
        //itemRadius = Physics.OverlapSphere(transform.position, itemRadius, int layerMask, QueryTriggerInteraction.UseGlobal);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
