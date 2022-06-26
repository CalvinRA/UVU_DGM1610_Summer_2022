using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Note I didn't have the right version of Visual Studio installed before this challenge so the goal I had here was mostly to redo and test things
//to make sure I had everthing proporly set up this time.
public class Unit3ChallengeScript : MonoBehaviour
{   
    public float range;
    public Text textOutput;

    int testNum = 15;

    public class Armor
    {
        public int helmet;
        public int cheastPlate;
        public int gauntlet;
        public int legging;
        public int total;

        

        public Armor(int helm, int cheast, int gaunt, int leg)
        {
            helmet = helm;
            cheastPlate = cheast;
            gauntlet = gaunt;
            legging = leg;

            total = helm + cheast + gaunt + leg;
        }
    }

    public Armor knight = new Armor(10, 12, 9, 13);

    public GameObject[] players;
    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        testNum = TestNumber(testNum);
        Debug.Log(testNum);

        //using this to test if visual studios is working with unity properly ie if erros, functions, methods and others things
    //are getting reconized by visual studios
    int TestNumber(int number)
    {
        int result;
        result = number * 2;
        return result;
    }

        Debug.Log("Activate Self:" + myObject.activeSelf);
        Debug.Log("Activate in Hierarchy " + myObject.activeInHierarchy);

        players = GameObject.FindGameObjectsWithTag("Player");

        for(int i = 0; i < players.Length; i++)
        {
            Debug.Log("Character Number " + i + "is named " + players[i].name);
        }
        
        Debug.Log(knight.total);
    }

    public Transform other;
    
    //used to test using control+shift+m to use the monobehaivor wizard to get unity functions
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate time " + Time.deltaTime);
    }


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");

        if(other)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 toOther = other.position - transform.position;

            if (Vector3.Dot(forward, toOther) < 0)
            {
                print("The other transform is behing me!");
            }
        }
    }
}
