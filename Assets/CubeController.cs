using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeController : MonoBehaviour {

	public bool touch = true;
	public Controller jump;

	public void disable()
	{
		gameObject.SetActive(false);
	}

	public void enable()
	{
		gameObject.SetActive(true);
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow) && touch==true)
		{
			Rigidbody rb = GetComponent<Rigidbody>();
			rb.AddForce(Vector3.up * 1200);
			rb.useGravity = true;
			touch = false;
			jump.jump = false;
		}
		if(gameObject.transform.position.y < 0)
		{
			Rigidbody rb = GetComponent<Rigidbody>();
			rb.useGravity = false;
			rb.velocity = Vector3.zero;

			Vector3 pos = gameObject.transform.position;
			pos.y = 1;
			gameObject.transform.position = pos;
			touch = true;
			jump.jump = true;

		}
	}



}
