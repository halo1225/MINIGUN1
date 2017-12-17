using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuguai : MonoBehaviour {
	public GameObject guai;
	float timer=0;
	public float jian = 0.5f;
	GameObject gz;
	// Use this for initialization
	void Start () {
		gz = GameObject.Find ("gz");
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 1 / jian) {
			timer -= 1 / jian;
			GameObject gw=(GameObject)Instantiate (guai,transform.position,transform.rotation);
			gw.transform.parent = gz.transform;
		}
	}
}
