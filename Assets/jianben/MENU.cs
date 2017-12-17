using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MENU : MonoBehaviour {
	public allen a;
	public boss b;
	public kongzhi k;
	//public GameObject text;
	//public GameObject inputtext;
	void Start(){
		Cursor.visible =true;
	}
	public void OnStartButtonClicked(){
		SceneManager.LoadScene ("MINIGUN");
	}
	// Use this for initialization
	// Update is called once per frame
	public void easy(){
		a.hp = 100;
		b.hp = 20000;
		k.shijian = 200f;

	}

	public void hard(){
		a.hp = 500;
		b.hp = 50000;
		k.shijian = 300f;
	}
	public void quit(){
		Application.Quit ();
	}
	//mouse stay
	void Update(){
		Cursor.visible = true;
		Cursor.lockState = 0;
	}
}
