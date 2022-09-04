using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO; 
using System.Runtime.Serialization.Formatters.Binary; 

public static class SaveSystem
{
    public static void SaveProgress (int progress){
        BinaryFormatter formatter = new BinaryFormatter(); 
        string path = Application.persistentDataPath + "/progress.fuck";
        FileStream stream = new FileStream(path, FileMode.Create); 

        SaveManager save = new SaveManager(SceneManager.GetActiveScene().buildIndex);

        formatter.Serialize(stream, save);
        stream.Close();
    }

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
            Debug.Log("Save no work" + path);
            return 0; 
        }
    }

}
