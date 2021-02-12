using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointhareket : MonoBehaviour
{
    public bool degdi=false;
    bool oldu = false;
    void Start()
    {
        
    }

    
    void Update()
    {   
        if (transform.eulerAngles.z < 1) { oldu = true; }
        if (oldu == false)
        {
            if (degdi == true) { transform.Rotate(0, 0, -1); }
        }
        if (oldu == true) { gameObject.GetComponent<Animator>().enabled = true; }
    }
}
