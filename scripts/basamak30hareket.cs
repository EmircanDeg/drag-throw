using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basamak30hareket : MonoBehaviour
{
    public float guc;
    Rigidbody rigid;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        rigid.AddForce(0, guc, 0);
    }

    void firlat() { rigid.AddForce(0, guc, 0); }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "yukari") { rigid.velocity = Vector3.zero; }
        if (other.gameObject.tag == "asagi") { rigid.velocity = Vector3.zero;Invoke("firlat", 0.5f); }
    }
    void Update()
    {
        
    }
}
