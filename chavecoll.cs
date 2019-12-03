using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chavecoll : MonoBehaviour
{
    public Animator anim;
    int countKey = 2;
    public Text vitoria;
    public float tempo = 0.0f; //
    // Start is called before the first frame update
    void Start()
    {
        countKey = GameObject.FindGameObjectsWithTag("chave").Length;

    }

    // Update is called once per frame
    void Update()
    {
        if (countKey == 0)
        {
            if(tempo == 0)
            {
                anim.SetTrigger("porta");
            }
            

            tempo += Time.deltaTime;
            if (tempo > 5f)
            {
                vitoria.gameObject.SetActive(true);
                Time.timeScale = 0;
            }


        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "chave")
        {
            countKey--;
            Destroy(other.gameObject);
        }
        
    }
}
