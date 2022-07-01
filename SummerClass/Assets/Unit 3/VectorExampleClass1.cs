using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExampleClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform other;

    // Update is called once per frame
    void Update()
    {
        if (other)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 toOther = other.position - transform.position;

            if (Vector3.Dot(forward, toOther) < 0)
            {
                print("The other transform is behind me!");
            }
        }
    }
}
