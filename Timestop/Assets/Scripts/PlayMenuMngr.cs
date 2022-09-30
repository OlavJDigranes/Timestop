using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenuMngr : MonoBehaviour
{

    public void StartNewGame()
    {
        //Remove PRevious save
        SaveSystem.NukeSaves();

        //Start new game 
        SceneManager.LoadScene(1); 
    }

    public void LoadSaveGame()
    {
        //Debug.Log("Save's nae implemented yet");

        //load inbdex from binary save file/ 
        //Auto save after every ended level. 
        int index = SaveSystem.LoadProgress();
        //I think this should work as the save should load onto the first uncompleted scene. 
        SceneManager.LoadScene(index + 1);

    }

    public void Tutorial()
    {
        //Change this to always be the last index
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
    }

    public void LoadMainMenu(){
        //Main menu will always be at index 0
        SceneManager.LoadScene(0);
    }
}
