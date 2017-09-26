using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public CubeController right;
	public CubeController left;
	public CubeController middle;
	public bool jump = true;

	enum Position  {left, middle, right };
	Position loc = Position.middle;
	// Use this for initialization
	void Start () {

	}



	// Update is called once per frame
	void Update () {
		Vector3 pos = gameObject.transform.position;
		pos.z = pos.z + 1f;
		gameObject.transform.position = pos;

		if(Input.GetKeyDown(KeyCode.LeftArrow) && jump==true)
		{
			if(loc == Position.right)
			{
				loc = Position.middle;
			}
			else if(loc == Position.middle)
			{
				loc = Position.left;
			}
		}

		if (Input.GetKeyDown(KeyCode.RightArrow) && jump==true)
		{
			if (loc == Position.middle)
			{
				loc = Position.right;
			}
			else if (loc == Position.left)
			{
				loc = Position.middle;
			}
		}



		if (loc != Position.right)
		{
			right.disable();
		}
		if (loc != Position.middle)
		{
			middle.disable();
		}
		if (loc != Position.left)
		{
			left.disable();
		}


		if (loc == Position.right)
		{
			right.enable();
		}
		if (loc == Position.middle)
		{
			middle.enable();
		}
		if (loc == Position.left)
		{
			left.enable();
		}

	}
}