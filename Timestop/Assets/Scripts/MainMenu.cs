using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Yer done cunt");
            Application.Quit();
        }
    }

    public void Exit()
    {
        Debug.Log("Yer done cunt"); 
        Application.Quit(); 
    }
}