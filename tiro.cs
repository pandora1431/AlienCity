using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour {
public Transform projetil;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown("x"))
		{
			Instantiate(projetil, this.gameObject.transform.GetChild(0).transform.position, Quaternion.identity);
		}
	}
}
