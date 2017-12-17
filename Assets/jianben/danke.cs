using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danke : MonoBehaviour {
	public GameObject k;
	public GameObject danjia;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1")){
			GameObject da = (GameObject)Instantiate (k,transform.position,Quaternion.identity);
			Vector3 fwd = transform.TransformDirection (Vector3.back);
			Rigidbody c = da.GetComponent<Rigidbody> ();
			c.AddForce (fwd*100);
			c.AddTorque (new Vector3(90,0,0));
			da.transform.parent = danjia.transform;
		}
	}
}
