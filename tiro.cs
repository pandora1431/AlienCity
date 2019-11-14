using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour {
public Transform projetil_1;
public Transform projetil_2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
		
	}

    public void Atirar(int armaAtual)
    {
        if(armaAtual == 1)
        {
            Instantiate(projetil_1, this.gameObject.transform.GetChild(0).transform.position, Quaternion.identity);
        }
        else if (armaAtual == 2)
        {
            Instantiate(projetil_2, this.gameObject.transform.GetChild(0).transform.position, Quaternion.identity);
        }
            
    }
}
