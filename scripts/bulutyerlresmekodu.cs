using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulutyerlresmekodu : MonoBehaviour
{
    float x;
    float y;
    float z;
    float aci;
    void Start()
    {
        aci = Random.Range(0, 360);
        x = Random.Range(-3f,3f);
        y = Random.Range(25,70);
        z = Random.Range(45, 60);
        transform.position = transform.position + new Vector3(x,y,z);
        transform.eulerAngles = new Vector3(-90, aci, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
