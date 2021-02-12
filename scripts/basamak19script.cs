using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basamak19script : MonoBehaviour
{
    Rigidbody rigid;
    float hiz;
    void Start()
    {
        transform.position = transform.position + new Vector3(0, 5, 0);
        rigid = gameObject.GetComponent<Rigidbody>();
        hiz = Random.Range(-0.5f, -0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        rigid.angularVelocity = new Vector3(0, 0, hiz);
    }
}
