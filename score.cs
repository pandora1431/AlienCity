using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text pontos;
    private int pontuacao;

    // Start is called before the first frame update
    void Start()
    {
        pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pontos.text = "pontuação: " + pontuacao;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pedra")
        {
            other.gameObject.SetActive(false);
            pontuacao = pontuacao + 10;
        }
    }
}
