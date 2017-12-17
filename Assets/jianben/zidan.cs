using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zidan : MonoBehaviour {
	public GameObject effect1;
	public GameObject effect2;
	GameObject danjia;
	// Use this for initialization

	void Start(){
		danjia = GameObject.FindGameObjectWithTag ("danjia");
	}
	void Update(){
		Destroy (gameObject,3);
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "allen"||other.gameObject.tag == "boss") {
			if (effect1 != null) {
				Instantiate (effect1,transform.position,transform.rotation).transform.parent=danjia.transform;
			}
			Destroy (gameObject);
		}
		if (other.gameObject.tag == "di") {
			if (effect1 != null) {
				Instantiate (effect2,transform.position,transform.rotation).transform.parent=danjia.transform;
			}
			Destroy (gameObject);
		}
	}
}
