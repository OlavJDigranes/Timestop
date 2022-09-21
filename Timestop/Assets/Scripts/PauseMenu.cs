using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; 
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI; 
    public EventSystem eventSys; 
    public Canvas canvas; 

    //public static PauseMenu pm; 

    void Awake() {
        int num = FindObjectsOfType<EventSystem>().Length; 
        Debug.Log(num);
        if(num == 0){
            //Destroy(this.eventSys);
            //Destroy(this.canvas); 

            DontDestroyOnLoad(eventSys); 
            DontDestroyOnLoad(canvas); 
        }
        else{
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex != 0)
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true; 
    }

    public void ExitToMenu()
    {
        //Return to main menu
        Time.timeScale = 1f;
        SceneManager.LoadScene(0, LoadSceneMode.Single); 
    }

    public void LevelReload(){
        //Use this for future implementation of a reset button
        Resume();
        //Scene scene = SceneManager.GetActiveScene(); 
        //SceneManager.LoadScene(scene.name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        
    }
}
