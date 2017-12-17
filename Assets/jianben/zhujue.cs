using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class zhujue : MonoBehaviour {
	public int hp1 = 100;
	float timer=0f;
	public float jian=2f;
	public Text h1;

	// Use this for initialization

	/*void setHp(int hp){
		hp1 = hp;
	}*/
	// Update is called once per frame
	void Update () {
		h1.text = "HP:"+hp1;
		if (hp1 <= 0) {
			SceneManager.LoadScene ("dead");
		}
	}

	void OnControllerColliderHit(ControllerColliderHit hit){
		if (hit.gameObject.tag == "allen") {
			timer += Time.deltaTime;
			if (timer > 1 / jian) {
				timer -= 1 / jian;
				hp1 -= 25;
				if (hp1 <= 0) {
					SceneManager.LoadScene ("dead");
				}
			}
		}
		if (hit.gameObject.tag == "boss") {
			
		
				hp1 -= 50;
				if (hp1 <= 0) {
					SceneManager.LoadScene ("dead");
				}

		}
	}
}
