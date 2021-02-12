using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terstbasamakscript : MonoBehaviour
{
    public float hiz=1;
    float xyeri;
    //bool ilerimi = true;
    Rigidbody rigid;
    public GameObject alti;
    public bool kolmu = true;

    void Start()
    {
        if (kolmu == true) { transform.position = new Vector3(transform.position.x, alti.transform.position.y + 11.5f, transform.position.z); }
        
        hiz = Random.Range(-3, 3);
        if (hiz == 0) { hiz = Random.Range(-3, 3); }
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.angularVelocity = new Vector3(0, 0, hiz);
    }
}
