using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMainMenu : MonoBehaviour
{
    public GameObject SettingsNHelpMenu; 
    public GameObject MainMenu; 
    public GameObject PlayMenu; 
    public GameObject CreditsMenu; 
    public GameObject SettingsMenu; 
    public GameObject HelpMenu; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu.SetActive(true);
            SettingsNHelpMenu.SetActive(false);
            PlayMenu.SetActive(false);
            CreditsMenu.SetActive(false);
            SettingsMenu.SetActive(false);
            HelpMenu.SetActive(false);
        }
    }
}
