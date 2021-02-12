using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cikaricitetikscript : MonoBehaviour
{
    GameObject cikarici;
    void Start()
    {
        cikarici = GameObject.Find("cikarici");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") { cikarici.GetComponent<summoncuscript>().cikart(); Destroy(gameObject); }
        
    }
    void Update()
    {
        
    }
}
