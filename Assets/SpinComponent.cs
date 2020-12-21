using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SpinComponent : MonoBehaviour
{
    private Transform myTransform;
    private bool printedmessage = false;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        Debug.Log(myTransform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(printedmessage == false)
        {
            Debug.Log("Hello from Update");
            printedmessage = true;
        }
        myTransform.Rotate(0.1f, 0f, 0f);
    }
}
