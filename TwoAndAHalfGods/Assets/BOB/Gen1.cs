using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gen1 : MonoBehaviour
{
    public 
    float x = 0;
    bool first = true;
    // Start is called before the first frame update
    void Start()
    {
        if (first)
        {
            transform.position = new Vector3(-300, 0, 0);
            print(transform.position);
            Instantiate(this);
            transform.position = new Vector3(-200, 0, 0);
            Instantiate(this);
            transform.position = new Vector3(-100, 0, 0);
            Instantiate(this);
            transform.position = new Vector3(-000, 0, 0);
            Instantiate(this);
            first = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 0.1f;
        
        
    }
}
