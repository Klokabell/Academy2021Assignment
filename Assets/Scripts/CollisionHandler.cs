using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    public ParticleSystem playerDeath;
       
    Color RED = new Color(1f, 0f, 0f, 0.5f);
    Color GREEN = new Color(0f, 1f, 0f);
    Color BLUE = new Color(0f, 0f, 1);
    Color PURPLE = new Color(1f, 0f, 1f);

    
    int colorRandom;
    Color[] colorArray;
    
    




    void Start()
    {
        colorArray = new Color[]{RED, GREEN, BLUE, PURPLE};
    }



     void Update()
    {
        
    }



    void OnCollisionEnter2D(Collision2D other) 
    {

    //Turns the player into a random colour from the array before then using the assigned number to change the tag on the player character
        if(other.gameObject.tag == "Changer")
            {
        colorRandom = UnityEngine.Random.Range(0, 4);
        gameObject.GetComponent<SpriteRenderer>().color = colorArray[colorRandom];
        Destroy(other.gameObject);

        //Switch statement is used to determine which tag goes with which colour
                switch(colorRandom)
                    {
                        case 0:
                        gameObject.tag = "Red";
                        break;

                        case 1:
                        gameObject.tag = "Green";
                        break;

                        case 2:
                        gameObject.tag = "Blue";
                        break;

                        case 3:
                        gameObject.tag = "Purple";
                        break;

                         default:
                         break;
                    }
    
            }


        // Does nothing if the object is tagged as a Star
        else if(other.gameObject.tag == "Star")
            {
            }
    

        // Supposed to turn off the collider of any objects that have the same tag as the player
        else if(other.gameObject.tag == this.gameObject.tag)
            { 
                other.gameObject.GetComponent<Collider2D>().enabled = false;
            }        
    
        // Turns the colliders on for all objects that don't have matching tags, to ensure they dont constantly stay off
        else if(other.gameObject.tag != this.gameObject.tag)
            { 
                other.gameObject.GetComponent<Collider2D>().enabled = true;
                DeadPlayer();
            }    

        else if(other.gameObject.tag == "Death")
            {
                DeadPlayer();
            }      

        else
            {
                DeadPlayer();
            }

    }   

   

    // plays the death effect and hides the player sprite
    void DeadPlayer()
    {
        playerDeath.Play();
        GetComponent<SpriteRenderer>().enabled = false;  
        Score.playerScore = 0;   
        SceneManager.LoadScene(0);
    } 
   

}



