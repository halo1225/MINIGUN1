using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sheji : MonoBehaviour {
	public GameObject g;
	public GameObject effect1;
	public GameObject danjia;
	int shu = 1;
	public Text zi;
	float timer=0f;
	float jian=100f;
	//射击间隔
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1")){
			timer += Time.deltaTime;
			if (timer > 1 / jian) {
				timer -= 1 / jian;
				she ();
			}
			//射击间隔

		}
	}
	void she(){
		GameObject zidan = (GameObject)Instantiate (g,transform.position,transform.rotation);
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		Rigidbody c = zidan.GetComponent<Rigidbody> ();
		c.AddForce (fwd*150000);
		if (effect1 != null) {
			Instantiate (effect1,transform.position,transform.rotation).transform.parent=danjia.transform;
		}
		zidan.transform.parent = danjia.transform;

		zi.text = "Firepower:" +shu;
		shu++;
	}

}
