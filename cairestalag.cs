using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cairestalag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider estalag)
    {
        if (estalag.tag == "Player")
        {
            for(int i = 0; i < 4; i ++)
            {
                this.gameObject.transform.GetChild(i).GetComponent<Rigidbody>().useGravity = true;
            }

        }
    
    
    }

}
