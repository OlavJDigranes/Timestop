using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;

public class FinalLevelUI : MonoBehaviour
{
    public TextMeshProUGUI ted2;
    public Transform p1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(p1.transform.position.x >= 86 && ted2.text != "Specimen S539-77 Status: SUCCESS"){
            ted2.text = "Specimen S539-77 Status: SUCCESS"; 
        }
    }
}
