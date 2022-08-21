using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    /*
    PLAYER MOVEMENT CLASS EXPLANATION:
    This class handles the player input to control the movement of the player 
    character in the game. 
    */

    public Rigidbody2D rb;
    bool jump = false;
    int jumpNum = 0;
    int jumpMax = 2;
    public float playerHealthCurrent; 
    public float playerHealthMax = 100.0f; 
    float horizontalMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.transform.position = new Vector3(-6, 0, 0);
        playerHealthCurrent = playerHealthMax; 
    }

    // Update is called once per frame
    private void Update()
    {
        
        //Move Left
        if (Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector2(-5, rb.velocity.y);
        }
        
        //Move Right
        if (Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector2(5, rb.velocity.y);
        }

        //Jumping, with double jump. 
        if (Input.GetKeyDown(KeyCode.Space) && jumpNum <= jumpMax){
            rb.velocity = new Vector2(rb.velocity.x, 5.0f);
            jumpNum ++; 
        }
        else if(jumpNum == jumpMax){
            jumpNum++;
            jump = true;
        }

        if (rb.transform.position.y <= -7) {
            LevelReload(); 
        }
    }

    //Collision Detecter
    void OnCollisionEnter2D(Collision2D col){
        jumpNum = 0; 
        jump = false;

    }

    private void OnCollisionStay2D(Collision2D col){
        if(col.collider.tag == "Enemy"){ //Only Tile enemy
            playerHealthCurrent -= 1; 
            
            if(playerHealthCurrent == 0){
                LevelReload();
            }
        }
    }

    public void LevelReload(){
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
       
}


//AUTHOR: Olav Jakobson Digranes, created 28th of October 2021
//Code largely taken from previous projects, especially GGJ2020

/*
OTHER SOURCES:
https://www.codegrepper.com/code-examples/csharp/2d+movement+unity 
*/

//   __O
//  / /\_               
// __/\                  
//    /