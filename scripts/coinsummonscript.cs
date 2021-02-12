using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsummonscript : MonoBehaviour
{
    public GameObject coin;
    int sec;
    void Start()
    {
        sec = Random.Range(0, 11);
        if (sec > 3) { Instantiate(coin, transform.position, transform.rotation); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
