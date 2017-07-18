using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camCont : MonoBehaviour {

	public Camera a;
	public Camera b;
	public Camera c;
	public Camera d;
	public Camera e;
	public Camera f;
	public Camera g;
	public Camera h;
	public Camera i;
	public Camera j;
	public Camera k;


	bool started = false;
	float startTime;
	float curTime;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			started = true;
			startTime = Time.time;
		}
		if (started) {
			curTime = Time.time - startTime;
			if (curTime > 5.6f) {
				a.enabled = false;
				b.enabled = true;
			}
			if (curTime > 7.7f) {
				b.enabled = false;
				c.enabled = true;
			}
			if (curTime > 14.5f) {
				c.enabled = false;
				d.enabled = true;
			}
			if (curTime > 21.5f) {
				d.enabled = false;
				e.enabled = true;
			}
			if (curTime > 29f) {
				e.enabled = false;
				f.enabled = true;
			}
			if (curTime > 33f) {
				f.enabled = false;
				g.enabled = true;
			}
			if (curTime > 47f) {
				g.enabled = false;
				h.enabled = true;
			}
			if (curTime > 61f) {
				h.enabled = false;
				i.enabled = true;
			}
			if (curTime > 88f) {
				i.enabled = false;
				j.enabled = true;
			}
			if (curTime > 96f) {
				j.enabled = false;
				k.enabled = true;
			}


		}
		Debug.Log (curTime);

	}
}
