using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basamak35script : MonoBehaviour
{
    float guc;
    Rigidbody rigid;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        guc = Random.Range(-3, -5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "asagi") { guc = -guc ; }
        if (other.gameObject.tag == "yukari") { guc = -guc ; }
    }
    void Update()
    {
        rigid.velocity = new Vector3(guc, 0, 0);
    }
}
