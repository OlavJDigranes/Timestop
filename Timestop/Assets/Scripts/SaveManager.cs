using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class SaveManager 
{
    public int savedLevelIndex; 

    public SaveManager(int levelIndex){
        savedLevelIndex = levelIndex; 
    }
}

//The source for this I tihnk was Brackeys on YT. 