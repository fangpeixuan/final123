using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour {

	GameObject enemy;
	// Use this for initialization
	void Start () {

	}
	public int enemy_Life = 50;

	// Update is called once per frame
	void Update () {
		
		if (enemy_Life == 0) {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		takeDamage ();
	}

	public void takeDamage(){
		enemy_Life = enemy_Life - 10;


	}
}