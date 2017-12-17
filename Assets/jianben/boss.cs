using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour {
	GameObject player;
	private UnityEngine.AI.NavMeshAgent nav;
	public int hp=10000;
	//public int playerhp = 100;
	Animator ani1;
	public GameObject effect1;
	public Vector3 effectRotation;
	Vector3 m,n;
	float timer=0f;
	public float jian=2f; 
	GameObject danjia;
	//public zhujue zhu;

	//GameObject player1;
	// Use this for initialization
	void Start () {
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		ani1 = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		danjia = GameObject.FindGameObjectWithTag ("danjia");
		//player1 = GameObject.FindGameObjectWithTag ("Player").GetComponent<zhujue> ().hp1;
	}

	// Update is called once per frame
	void Update () {

		m = player.transform.position;
		n = transform.position;
		//transform.LookAt(player.transform);
		nav.SetDestination (player.transform.position);
		//MoveTo(); 

		if (Vector3.Distance (n, m) < 50f) {
			//ani1.SetTrigger ("dada");
			timer += Time.deltaTime;
			if (timer > 1 / jian) {
				timer -= 1 / jian;
				GameObject.FindGameObjectWithTag ("Player").GetComponent<zhujue> ().hp1-= 10;
				//if (zhu.hp1 <= 0) {
					//Destroy (player);
					//return;
				//}
			}
		}

		//Debug.Log (Vector3.Distance (n, m)<6f);

	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "ammo") {
			hp -= 25;
			ani1.SetTrigger ("beida");
			Destroy (other.gameObject);
			if (hp <= 0) {
				ani1.SetTrigger ("si");


				Destroy (gameObject,5f);
				

				//ani1.SetTrigger ("sishi");

				if (effect1 != null) {
					Instantiate (effect1, transform.position, Quaternion.Euler (effectRotation)).transform.parent=danjia.transform;
				}
			}
		}

	}
	/*void OnCollisionStay(Collision other){
		if (other.gameObject.tag == "Player") {
			ani.SetTrigger ("attck");
		}
	}*/
	/*void MoveTo()
	{
		//定义敌人的移动量
		float speed = 2 * Time.deltaTime;

		//通过寻路组件的Move()方法实现寻路移动
		nav.Move(transform.TransformDirection(new Vector3(0, 0, speed)));
	}*/
}
