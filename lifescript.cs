using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lifescript : MonoBehaviour
{
    public int startlife = 100;
    public int atuallife;
    public Slider lifeslider;

    bool isdead;
    bool damaged;
    // Start is called before the first frame update
    void Awake()
    {
        atuallife = startlife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void damage (int amount)
    {
        if (atuallife <= 10 && !isdead) 
        {
            
            morreu();
        }
        else 
        {
            damaged = true;
            atuallife -= amount;
            lifeslider.value = atuallife;
        }
    } 
    void morreu() 
    {
        isdead = true;
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}