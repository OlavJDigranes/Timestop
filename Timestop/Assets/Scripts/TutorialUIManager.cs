using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class TutorialUIManager : MonoBehaviour
{
    public Transform p1;
    public TextMeshProUGUI ted;

    bool part1 = false;
    bool part2 = false;
    bool part3 = false;
    bool part4 = false;

    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.Find("PlayerTest").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        if (p1.transform.position.x <= 1.0f && part1 == false)
        {
            ted.text = "Move using A for left and D for right";
        }

        if (p1.transform.position.x <= 5.0f && p1.transform.position.x >1.4f && part2 == false)
        {
            ted.text = "Jump using Space";
            part1 = true; 
        }

        if (p1.transform.position.x <= 8.0f && p1.transform.position.x > 5.0f && part3 == false)
        {
            ted.text = "Double jump by pressing Space twice";
            part2 = true;
        }

        if (p1.transform.position.x <= 30.0f && p1.transform.position.x > 8.0f && part4 == false)
        {
            ted.text = "Place platforms of yourself by jumping or otherwise placing yourself at the desired position and pressing Enter ";
            part3 = true;
        }

        if (p1.transform.position.x > 31.0f)
        {
            part4 = true;
            ted.text = "Hit the red button to finish the tutorial"; 
        }
    }
}
