using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloader : MonoBehaviour
{
    public List<float> tsPositionsX = new List<float>();
    public List<float> tsPositionsY = new List<float>();
    public Timestop ts;
    public GameObject PlayerPlatfrom;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate player timestops on reload. 
        //ts = true; 
        Debug.Log("fuck");
        for (int i = 0; i < tsPositionsX.Count; i++)
        {
            Debug.Log("cunt"); 
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
