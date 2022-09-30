using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class SaveManager 
{
    public int savedLevelIndex; 

    //This passes the progress index int to something. I can't entirely remember now but it works. 
    public SaveManager(int levelIndex){
        savedLevelIndex = levelIndex; 
    }
}

//The source for this I tihnk was Brackeys on YT. 