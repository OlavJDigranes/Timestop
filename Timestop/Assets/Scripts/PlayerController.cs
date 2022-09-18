using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    /*
    PLAYER MOVEMENT CLASS EXPLANATION:
    This class handles the player input to control the movement of the player 
    character in the game. 
    */

    public PlayerInput pInput; 
    public Rigidbody2D rb;
    //bool jump = false;
    int jumpNum = 0;
    int jumpMax = 2;
    public float playerHealthCurrent; 
    public float playerHealthMax = 100.0f; 
    float horizontalMovement;
    private float inX;
    private float inX2;
    float inHor;
    bool isFacingRight = true;

    public GameObject PlayerPlatfrom;
    public List<float> tsPositionsX = new List<float>();
    public List<float> tsPositionsY = new List<float>();
    public Transform p1;
    float playerPosX = -6;
    float playerPosY = 0;
    int i = 0;

    private void Awake()
    {
        //pInput = new PlayerInput();
        //pInput = GetComponent<PlayerInput>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.transform.position = new Vector3(-6, 0, 0);
        playerHealthCurrent = playerHealthMax; 
    }

    // Update is called once per frame
    private void Update()
    {
        rb.velocity = new Vector2(inX * 5, rb.velocity.y);

        if (inX > 0)
        {
            inX2 = inX;
        }
        if (inX < 0)
        {
            inX2 = inX;
        }
        if (inX == 0)
        {
            if (inX2 >= 0)
            {
                inX2 -= (Time.deltaTime * 2);
            }
            if (inX2 <= 0)
            {
                inX2 += (Time.deltaTime * 2);
            }
            
            rb.velocity = new Vector2(inX2 * 5, rb.velocity.y);
        }

        inHor = Input.GetAxisRaw("Horizontal"); 

        if (rb.transform.position.y <= -7) {
            LevelReload(); 
        }

        if (inHor > 0 && !isFacingRight)
        {
            //rb.transform.localScale = new Vecor3(1, 1, 1); 
            Flipper();
        }

        if (inHor < 0 && isFacingRight)
        {
            //rb.transform.localScale = new Vecor3(-1, 1, 1);
            Flipper();
        }

        
    }

    void Flipper()
    {
        Vector3 currentScale = rb.transform.localScale;
        currentScale.x *= -1;
        rb.transform.localScale = currentScale;
        isFacingRight = !isFacingRight; 
    }

    //Collision Detecter
    void OnCollisionEnter2D(Collision2D col){
        
        if((col.gameObject.tag != "Wall" && jumpNum >= 2) || (col.gameObject.tag == "PlayerPlatform")){
            jumpNum = 0;
        }
        
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

    public void Movement(InputAction.CallbackContext context)
    {
        inX = context.ReadValue<Vector2>().x;
    }

    public void Jumping(InputAction.CallbackContext context)
    {
        if (context.performed && jumpNum <= jumpMax)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5.2f);
            jumpNum++;
        }

        else if (jumpNum == jumpMax)
        {
            jumpNum++;
            //jump = true;
        }

    }
    
    public void Placement(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            tsPositionsX.Add(p1.position.x);
            tsPositionsY.Add(p1.position.y);

            Reset();

            
        }
    }

    public void Reset()
    {
        rb.transform.position = new Vector3(playerPosX, playerPosY, 0);

        GameObject pp = Instantiate(PlayerPlatfrom) as GameObject;
        pp.transform.position = new Vector3(tsPositionsX[i], tsPositionsY[i], 0);
        i++;

        
    }
}


//   __O
//  / /\_               
// __/\                  
//    /