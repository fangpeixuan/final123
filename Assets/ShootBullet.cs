using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour {

	void Start () {

	}
	public GameObject bulletPrefab;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject b = (GameObject)Instantiate (
				bulletPrefab,
				transform.position,
				transform.rotation);
			b.GetComponent<Rigidbody> ().velocity = transform.forward * 20;
		}
	}
}