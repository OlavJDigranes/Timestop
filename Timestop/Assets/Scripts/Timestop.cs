using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Timestop : MonoBehaviour
{
    //Not quite sure why this is still here...
    public Rigidbody2D rb;
    public Transform p1;
    float playerPosX = -6; 
    float playerPosY = 0;
    public PlayerController pc;
    //public Reloader r;
    public GameObject PlayerPlatfrom;
    public List<float> tsPositionsX = new List<float>();
    public List<float> tsPositionsY = new List<float>();
    int i = 0;

    //bool ts = false; 

    // Start is called before the first frame update
    void Start()
    {
        //if (ts == true) {
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //Get current position of player
        if (Input.GetKeyDown(KeyCode.Return)) {

            //r.tsPositionsX.Add(p1.position.x); 
            //r.tsPositionsY.Add(p1.position.y);

            tsPositionsX.Add(p1.position.x); 
            tsPositionsY.Add(p1.position.y);

            Reset(); 
            //pc.LevelReload();
        }
    }

    public void Reset()
    {
        rb.transform.position = new Vector3(playerPosX, playerPosY, 0); 

        GameObject pp = Instantiate(PlayerPlatfrom) as GameObject;
        pp.transform.position = new Vector3(tsPositionsX[i], tsPositionsY[i], 0);
        i++;

        Debug.Log(tsPositionsX);
        Debug.Log(tsPositionsY);
        Debug.Log(i);
    }
}


//   __O
//  / /\_               
// __/\                  
//    /

/*
 * Resources:
 * https://www.youtube.com/watch?v=E7gmylDS1C4
*/ 
