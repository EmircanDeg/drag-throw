using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donenbasamaktakip : MonoBehaviour
{
    public GameObject takip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = takip.transform.position;
    }
}
