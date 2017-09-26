using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceBlood : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		PlayerController p = other.GetComponent<PlayerController>();
		if (p != null) p.TakeDamage();
	}
}
