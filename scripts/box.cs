using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject[] dusecekler;
    float sayac = 0;
    bool degdi = false;
    int sec = 0;
    public GameObject sil1;
    public GameObject sil2;
    public GameObject sil3;
    public GameObject sil4;
    public GameObject sil5;
    public GameObject sil6;
    void Start()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") { degdi = true; }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player") { degdi = true; }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") { degdi = false; }
    }
    void Update()
    {
        if (degdi == true) 
        {
            sayac = sayac + Time.deltaTime;
            if (sayac > 0.15f) {dusecekler[sec].GetComponent<Rigidbody>().constraints= RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationY;sec++;sayac = 0; }
            if (sec == dusecekler.Length) { Destroy(gameObject); }
            if (sec == 30) { Destroy(sil1); }
            if (sec == 31) { Destroy(sil2); }
            if (sec == 32) { Destroy(sil3); }
            if (sec == 33) { Destroy(sil4); }
            if (sec == 34) { Destroy(sil5); }
            if (sec == 35) { Destroy(sil6); }
        }
    }
}
