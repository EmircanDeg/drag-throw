using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulutsilinmescript : MonoBehaviour
{
    GameObject player;
    
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x - transform.position.x > 50) { Destroy(gameObject); }
    }
}
