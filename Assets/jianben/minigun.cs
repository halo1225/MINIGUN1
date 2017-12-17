using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigun : MonoBehaviour {
	Animator a;
	AudioSource yin;
	// Use this for initialization
	void Start () {
		a = GetComponent<Animator> ();
		yin = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetMouseButton (0)) {
			a.SetTrigger ("open");

		} 

		if (Input.GetMouseButtonDown (0)) {
			yin.Play ();
		}
		else if(Input.GetMouseButtonUp(0)) {
			
			yin.Stop ();
		}

	}
}
