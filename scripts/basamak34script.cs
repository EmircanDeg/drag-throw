using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basamak34script : MonoBehaviour
{
    float guc;
    Rigidbody rigid;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        guc = Random.Range(-3, -6);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "asagi") { guc = -guc/2; }
        if (other.gameObject.tag == "yukari") { guc = -guc*2; }
    }
    void Update()
    {
        rigid.velocity = new Vector3(guc, 0, 0);
    }
}
