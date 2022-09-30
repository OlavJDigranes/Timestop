using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO; 
using System.Runtime.Serialization.Formatters.Binary; 

public static class SaveSystem
{
    //This took longer than it should have. I am also an idiot for trying to save a scenemanager and load it ias an int. end me. 
    //Writes the progress int to a binary file
    public static void SaveProgress (int progress){
        BinaryFormatter formatter = new BinaryFormatter(); 
        string path = Application.persistentDataPath + "/progress.fuck"; //This is just a binary file. The type is irrelevant. I assumed .fuck would not cause any issues with existing file types. 
        FileStream stream = new FileStream(path, FileMode.Create); 
        int save = SceneManager.GetActiveScene().buildIndex; 

        formatter.Serialize(stream, save);
        stream.Close();
    }

    //Loads progress from binary file
    public static int LoadProgress (){
        string path = Application.persistentDataPath + "/progress.fuck";
        
        if(File.Exists(path)){
            BinaryFormatter formatter = new BinaryFormatter(); 
            FileStream stream = new FileStream(path, FileMode.Open); 
            int progress = System.Convert.ToInt32(formatter.Deserialize(stream));
            stream.Close();
            return progress;
        }
        
        else{
            Debug.Log("Save nae work" + path);
            return 0; 
        }
    }

    //Removes save file if it exists
    public static void NukeSaves(){
        string path = Application.persistentDataPath + "/progress.fuck";
        if(File.Exists(path)){
            Debug.Log("Is gone");
            File.Delete(path);
        }
        else{
            Debug.Log("File's nuked already");
             
        }
    }

}

//The source for this I tihnk was Brackeys on YT. 