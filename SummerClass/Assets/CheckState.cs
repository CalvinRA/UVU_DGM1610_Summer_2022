using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Activate Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInhierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
