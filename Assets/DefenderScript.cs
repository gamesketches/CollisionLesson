using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderScript : MonoBehaviour {

	public int framesOnEnter;
	public int framesOnStay;
	public int framesOnExit;
	// Use this for initialization
	void Start () {
		framesOnEnter = 0;
		framesOnStay = 0;
		framesOnExit = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		framesOnEnter++;
	}

	void OnTriggerStay(Collider other) {
		framesOnStay++;
	}

	void OnTriggerExit(Collider other) {
		framesOnExit++;
	}

	void OnCollisionEnter(Collision col) {
		Destroy(col.gameObject);
	}

	void OnCollisionStay(Collision col) {

	}

	void OnCollisionExit(Collision col) {

	}
}
