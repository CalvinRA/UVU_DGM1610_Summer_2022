using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            pring ("Hello World");

        }while(shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
