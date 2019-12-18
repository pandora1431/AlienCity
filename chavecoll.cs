using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chavecoll : MonoBehaviour
{
    public Animator anim;
    int countKey = 2;
    public Text vitoria;
    public float tempo = 0.0f;
    public Text chaves;
    private int key;


    // Start is called before the first frame update
    void Start()
    {
        countKey = GameObject.FindGameObjectsWithTag("chave").Length;
        key = 0;
    }

    // Update is called once per frame
    void Update()
    {
        chaves.text = "key: " + key;
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
            key = key + 1;
            countKey--;
            Destroy(other.gameObject);
        }
        
    }
}
