using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class armasel : MonoBehaviour {

	Text armahud;
	PlayerController player;

	// Use this for initialization
	void Start () {
		armahud = GetComponent<Text> ();
		player = GameObject.Find("player").GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
	
		armahud.text = "arma: " + player.armaAtual.ToString();
		
		/*
		if (Input.GetKeyDown("z"))
			{
			if (arma == 1)
				arma = 2
			else
				arma = 1
			}
		*/
	}
}
