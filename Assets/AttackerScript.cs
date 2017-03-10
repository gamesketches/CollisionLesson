using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerScript : MonoBehaviour {

	public bool AddRigidbody;
	private bool moving;
	// Use this for initialization
	void Start () {
		if(AddRigidbody) {
			gameObject.AddComponent<Rigidbody>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			if(AddRigidbody) {
				gameObject.GetComponent<Rigidbody>().AddForce(1000, 0, 0);
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		
	}

	void OnTriggerStay(Collider other) {
	
	}

	void OnTriggerExit(Collider other) {

	}

	void OnCollisionEnter(Collision col) {

	}

	void OnCollisionStay(Collision col) {

	}

	void OnCollisionExit(Collision col) {

	}
}
