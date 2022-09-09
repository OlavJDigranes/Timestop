using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenuMngr : MonoBehaviour
{

    public void StartNewGame()
    {
        SceneManager.LoadScene(1); 

        //Need to add wipe of save data. 
    }

    public void LoadSaveGame()
    {
        //Debug.Log("Save's nae implemented yet");

        //load inbdex from save file/ 
        //Auto save after every ended level. Multiple save files?
        int index = SaveSystem.LoadProgress();
        SceneManager.LoadScene(index);

    }

    public void Tutorial()
    {
        //Change this to always be the last index
        //SceneManager.LoadScene(2);

        SceneManager.LoadScene(14);
    }

    public void LoadMainMenu(){
        SceneManager.LoadScene(0);
    }
}
