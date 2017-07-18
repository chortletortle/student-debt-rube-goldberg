using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 	

public class hoop : MonoBehaviour {

	public Text final;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		final.enabled = true;
	}
}
