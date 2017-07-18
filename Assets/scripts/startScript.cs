using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startScript : MonoBehaviour {
	Rigidbody rb;
	public Text tx;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.useGravity = true;
			tx.enabled = false;
		}
	}


}
