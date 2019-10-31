using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trocadesprinter : MonoBehaviour {

	private SpriteRenderer rend;
	private Sprite standSprite, stand2Sprite;

	// Use this for initialization
	private void Start () {
		rend = GetComponent<SpriteRenderer>();
		standSprite = Resources.Load<Sprite>("stand");
		stand2Sprite = Resources.Load<Sprite>("stand2");
		rend.sprite = standSprite;
	}
	
	// Update is called once per frame
	private void Update () {
		if (Input.GetKeyDown("z"))
		{
			if (rend.sprite == standSprite)
				rend.sprite = stand2Sprite;
			else if (rend.sprite == stand2Sprite)
					rend.sprite = standSprite;
		
		}
	}
}
