using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    public int intelligence = 5;

    void Greet()
    {
        switch(intelligence)
        {
        case 5:
            print("Why hello there good sir! Let me teach you about Trigonometry!");
            break;

        case 4:
            print("Hello and good day!");
            break;

        case 3:
            print("Whadya want?");
            break;

        case 2:
            print("Grog SMASH!");
            break;
        
        case 1:
            print("Ulg, glib, Pblblblblb");
            break;
        
        default:
            print("Incorrect intelligence level.");
            break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
