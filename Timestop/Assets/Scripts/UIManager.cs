using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI ted;
    int levelID; 
    

    //Use this to display level number, and specimen number. LEvel updates, speciment is constant

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        levelID = SceneManager.GetActiveScene().buildIndex;

        if(ted.text != "Chamber: " + levelID.ToString()){
            ted.text = "Chamber: " + levelID.ToString();
        }        
    }
}
