using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esascheckpoint : MonoBehaviour
{
    public GameObject donen;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") { donen.GetComponent<checkpointhareket>().degdi = true;Destroy(gameObject); }
    }
    void Update()
    {
        
    }
}
