using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    privatre Rigidboody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    privatre void Awake()
    {
        rb = GetComponent<Rigidboody>();
    }

    void OnMouseDown()
    {
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
