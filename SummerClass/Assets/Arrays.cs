using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] players;
    
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for(int i = 0; i < players.length; i++)
        {
            Debug.Log("Player Number " + i + " is named " + player[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
