using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dano : MonoBehaviour
{
    public float intervaloatk = 0.5f;
    public int attackdamage = 10;
    public GameObject Alien;
    public lifescript lifescript;
    float timer;
    // Start is called before the first frame update
    void Awake()
    {
        Alien = GameObject.Find("Alien");

        lifescript = Alien.GetComponent<lifescript>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Alien && timer >= intervaloatk)
        {
            attack();
        }
    }
    void attack()
    {
        timer = 0f;
        if (lifescript.atuallife > 0)
        {
            lifescript.damage(attackdamage);
        }
    }

}