using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letterTrigger : MonoBehaviour {

    public GameObject promptText;
    public GameObject letter;
    public bool trigger = false;


    // Use this for initialization
    void Start () {
        promptText.SetActive(false);
        letter.SetActive(false);
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.name == "FPSController")
        {
            promptText.SetActive(true);
            trigger = true;
        }
    }

    void OnTriggerExit ()
    {
        promptText.SetActive(false);
        letter.SetActive(false);
        trigger = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (trigger)
        {
            if (Input.GetKey(KeyCode.E))
            {
                letter.SetActive(true);
            }
        }
	}
}
