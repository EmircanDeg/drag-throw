using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertakip : MonoBehaviour
{
    GameObject player;
    public float zsi;
    float esasz;
    public float yfarki;
    public float xfarki;
    float zcik = 0;
    float carp;
    void Start()
    {
        player = GameObject.Find("player");
        esasz = zsi;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    
        transform.position = new Vector3(player.transform.position.x-xfarki, player.transform.position.y-yfarki, esasz);
    }
}
