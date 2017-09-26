using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchGun : MonoBehaviour {
	
		public GameObject weapon1;
		public GameObject weapon2;

		// Use this for initialization
		void Start () {
			weapon1.SetActive(true);
			weapon2.SetActive(false);
			
		}

		// Update is called once per frame
		void Update () {
			if (Input.GetKeyDown("1"))
			{
				weapon1.SetActive(true);
				weapon2.SetActive(false);
			}
			if (Input.GetKeyDown("2"))
			{
				weapon1.SetActive(false);
				weapon2.SetActive(true);
			}

		}
	}
