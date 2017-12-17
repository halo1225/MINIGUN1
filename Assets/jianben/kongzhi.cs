using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class kongzhi : MonoBehaviour {
	public float shijian;
	// Use this for initialization
	public Text s;
	float timer=0;
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		s.text = "TIME:" + (int)timer;
		if (timer > shijian) {
			SceneManager.LoadScene ("win");
		}
	}
}
