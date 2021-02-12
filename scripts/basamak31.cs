using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basamak31 : MonoBehaviour
{
    public GameObject basmak31;
    float hiz = 0;
    public float donmehiz;
    public bool basamakmi = false;
    Rigidbody rigid;
    void Start()
    {
        if (basamakmi == true) { rigid = gameObject.GetComponent<Rigidbody>(); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") { hiz = donmehiz; }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") { hiz = 0; }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player") { hiz = donmehiz; }
    }
    void Update()
    {
        if (basamakmi == true) { rigid.angularVelocity = new Vector3(0, 0, hiz); }
    }
}
