using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamento : MonoBehaviour {

	[SerializeField]
	private float velocidade;
	private Vector2 direcao;
	
	private Rigidbody2D rb2d;
	
	// Use this for initialization
	void Start () {
		
		rb2d = GetComponent<Rigidbody2D>();
		direcao = Vector2.right;
		
		
	}
	
	void FixedUpdate () {
	
		rb2d.velocity = direcao * velocidade;
		
	}

	void Update ()
	{
		Destroy(gameObject, 2f);
	
	}

}
