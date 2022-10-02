using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; 
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    /*
    Getting this cunt of a class and game object(s) to work was by far the most annoying thing I've had to do 
    in a while. Jesus fucking christ. ... Anyways, here's wonderwall. 

    Also I would private this code on GitHub but anyone dumb enough to copy it deservs the hell that awaits them. By now 
    anyone reading through it must surely be wondering "How the fuck does this work?", and to that I say "Ah 
    dinnae ken"

    Also, I'm sorry to every lecturer I've had that's taught me proper formatting and readability of code. I'm
    nae removing the superfluous comments. I just can't be arsed. And I'm not formatting this shite either. 
    */
    public static bool isPaused = false;
    public GameObject pauseMenuUI; 
    //public PauseMenu pmObj; 
    public GameObject pmObj; 
    //public EventSystem eventSys; 
    public GameObject eventSys; 
    //public Canvas canvas; 

    public static PauseMenu pm; 
    //public static EventSystem es; 
    //public static Canvas c;

    void Awake() {
        //DontDestroyOnLoad(eventSys); 
        //DontDestroyOnLoad(canvas);

        DontDestroyOnLoad(pmObj); 
        DontDestroyOnLoad(eventSys);
        
        //DontDestroyOnLoad(this); 
        
        //int num = FindObjectsOfType<EventSystem>().Length; 
        //Debug.Log(num);
        if(pm == null){
           //es = UnityEngine.EventSystems.EventSystem;
           //c = this;
           
           pm = this;                
        }
        else{
            //DestroyObject(this.eventSys);
            //DestroyObject(this.canvas); 
            DestroyObject(pmObj); 
            DestroyObject(eventSys); 
        }

        int num = FindObjectsOfType<EventSystem>().Length; 
        Debug.Log(num);
        if(num == 0){
            //eventSys.SetActive(false); 
        }

         
        
    }

    //Well this is useless now too. oh well. here it sits. 
    void OnEnable(){
        //eventSys.SetSelectedGameObject(pauseMenuUI);
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

    //Guess what this does
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    //Guess this too, you can win a prize
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        //eventSys.SetSelectedGameObject(pauseMenuUI);
        Time.timeScale = 0f;
        isPaused = true; 
    }

    public void ExitToMenu()
    {
        //Return to main menu
        Resume(); 
        SceneManager.LoadScene(0, LoadSceneMode.Single); 
    }

    public void LevelReload(){
        //Use this for future implementation of a reset button
        Resume();
        //Scene scene = SceneManager.GetActiveScene(); 
        //SceneManager.LoadScene(scene.name);
        //Destroy(pmObj); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        
    }
}

//This is not optimised. I know. for this it doesn't matter. 