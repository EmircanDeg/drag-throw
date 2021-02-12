using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basamak26donme : MonoBehaviour
{
    float hiz;
    public float hiz2;
    public bool sag = false;
    Rigidbody rigid;
    public bool zibap = false;
    public bool ivj = false;
    public float yekseni;
    void Start()
    {
        if (zibap == false) {
            if (sag == true) { hiz = Random.Range(3, 4); }
            if (sag == false) { hiz = Random.Range(-4, -3); }
        }
        if (zibap == true) { 
            hiz = hiz2;
            if (ivj == true) { transform.position = transform.position + new Vector3(0, yekseni, 0); }
        }
        
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.angularVelocity = new Vector3(0, 0, hiz);
    }
}
