using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLaneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void processHit()
    {
        transform.Rotate(Vector3.right, -10);
    }
}
