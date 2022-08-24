using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenuMngr : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

    public void StartNewGame()
    {
        SceneManager.LoadScene(1); 

        //Need to add wipe of save data. 
    }

    public void LoadSaveGame()
    {
        Debug.Log("Save's nae implemented yet");

        //load inbdex from save file/ 
    }
}
