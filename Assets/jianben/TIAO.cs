using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TIAO : MonoBehaviour {

	// Use this for initialization
	public void OnStartButtonClicked(){
		SceneManager.LoadScene ("MENU");
	}
	void Update(){
		
		if (Input.GetMouseButtonDown(0)) {
			SceneManager.LoadScene ("MENU");
		}
	}
}
