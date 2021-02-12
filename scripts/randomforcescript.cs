using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomforcescript : MonoBehaviour
{
    Rigidbody rigid;
    public float guc;
    float gucx;
    float gucy;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        gucy = Random.Range(guc / 2, guc);
        gucx = Random.Range(guc /2, guc);
        rigid.AddForce(gucx, gucy, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
