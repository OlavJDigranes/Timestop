using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timestop : MonoBehaviour
{
    public Transform p1;
    float playerPosX; 
    float playerPosY;
    public PlayerController pc;
    public Reloader r;
    public GameObject PlayerPlatfrom;
    public List<float> tsPositionsX = new List<float>();
    public List<float> tsPositionsY = new List<float>();

    //bool ts = false; 

    // Start is called before the first frame update
    void Start()
    {
        //if (ts == true) {
        //}
        for (int i = 0; i < tsPositionsX.Count; i++)
        {
            GameObject pp = Instantiate(PlayerPlatfrom) as GameObject;
            pp.transform.position = new Vector3(tsPositionsX[i], tsPositionsY[i], 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Get current position of player
        if (Input.GetKey(KeyCode.Return)) {
            playerPosX = p1.position.x; 
            playerPosY = p1.position.y;

            //r.tsPositionsX.Add(p1.position.x); 
            //r.tsPositionsY.Add(p1.position.y);

            tsPositionsX.Add(p1.position.x); 
            tsPositionsY.Add(p1.position.y);

            pc.LevelReload();
        }
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
