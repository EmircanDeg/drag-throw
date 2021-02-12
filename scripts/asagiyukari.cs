using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asagiyukari : MonoBehaviour
{
    public bool yukari = true;
    public float hiz = 1;
    Rigidbody rigid;
    public float y;
    void Start()
    {
        y = transform.position.y;
        if (yukari == false) { hiz = -hiz; }
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = new Vector3(0, hiz, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "asagi") { hiz = -hiz; }
    }
}
