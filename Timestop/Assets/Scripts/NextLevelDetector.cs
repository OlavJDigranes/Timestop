using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelDetector : MonoBehaviour
{
    int levelIndex; 
    // Start is called before the first frame update
    void Start()
    {
        levelIndex = SceneManager.GetActiveScene().buildIndex; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        //Pseudocode:
            //When player hits trigger
                //Save progress to current save file. 
                //Progress to next level index. 

        //Temporary for testing
        Scene scene = SceneManager.GetActiveScene(); 
        //SceneManager.LoadScene(scene.name);
        SaveSystem.SaveProgress(SceneManager.GetActiveScene().buildIndex);
        levelIndex++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(levelIndex);
    }
}
