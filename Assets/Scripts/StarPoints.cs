using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPoints : MonoBehaviour
{
    public ParticleSystem starCollected;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)    
    {
      if(other.name == "Player") 
        {
            Points();        
        }
    }


    void Points()
        {   
            Score.playerScore += 1;
            starCollected.Play();
            gameObject.GetComponent<SpriteRenderer>().enabled = false; 

        }


    void Update()
    {
        
    }
}
