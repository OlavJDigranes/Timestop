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

    string info1 = "Move using A for left and D for right"; 
    string info2 = "Jump using Space";
    string info3 = "Double jump by pressing Space twice";
    string info4 = "Place platforms of yourself by jumping or otherwise placing yourself at the desired position and pressing Enter ";
    string info5 = "Hit the red button to finish the tutorial"; 

    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.Find("PlayerTest").transform; 
    }

    // Update is called once per frame. The text is not chnaged unless all conditions are met. 
    //As such, the canvas is only repainted five times. Thus, optimization of the tutorial is done. 
    void Update()
    {
        if (p1.transform.position.x <= -2.0f && part1 == false && ted.text != info1)
        {
            ted.text = info1;
        }

        if (p1.transform.position.x <= 4.5f && p1.transform.position.x >= -2.0f && part2 == false && ted.text != info2)
        {
            ted.text = info2; 
            part1 = true; 
        }

        if (p1.transform.position.x <= 8.0f && p1.transform.position.x > 4.5f && part3 == false && ted.text != info3)
        {
            ted.text = info3; 
            part2 = true;
        }

        if (p1.transform.position.x <= 30.0f && p1.transform.position.x > 7.0f && part4 == false && ted.text != info4)
        {
            ted.text = info4; 
            part3 = true;
        }

        if (p1.transform.position.x > 31.0f && ted.text != info5)
        {
            part4 = true;
            ted.text = info5; 
        }
    }
}
