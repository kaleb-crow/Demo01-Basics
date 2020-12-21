using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinComponent : MonoBehaviour
{
    bool printedmessage = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello from Start");
    }

    // Update is called once per frame
    void Update()
    {
        if(printedmessage == false)
        {
            Debug.Log("Hello from Update");
            printedmessage = true;
        }
    }
}
