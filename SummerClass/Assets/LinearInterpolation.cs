using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    float result = Mathf.Lerp (3f, 5f, 0.5f);

    Vector3 from = new Vector3 (1f, 2f, 3f);
    Vector3 to = new Vector3 (5f, 6f, 7f);

    

    // Start is called before the first frame update
    void Start()
    {
        // Here result = (4, 5, 6)
        Vector3 resultV = Vector3.Lerp (from, to, .75f);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, 8f, 0.5f);
        GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, 8f, 0.5f * Time.deltaTime);
    }
}
