using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	void Start () {
	}

	// Update is called once per frame
	public int playersLife = 100;
	public Text txt;
	void Update () {
		txt.text = "Player：" + " " + playersLife;
		if (playersLife == 0) {
			SceneManager.LoadScene("scene1", LoadSceneMode.Single);
		}
	}
	public void TakeDamage()
	{        
		playersLife = playersLife - 10;
	}

	public void HealDamage()
	{

		playersLife = playersLife + 10;

	}
}
