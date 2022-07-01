using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{   
    public string myName;

    void Awake ()
    {
        Debug.Log("Awake called.");
    }

    void Start ()
    {
        Debug.Log("Start called.");
        Debug.Log("I am alive and my name is " + myName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
