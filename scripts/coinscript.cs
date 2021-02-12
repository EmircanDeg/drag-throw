using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
    public GameObject efekt;
    public GameObject fiskirik;
    public bool kalpmi = false;
    int rastgel;
    GameObject player;
    void Start()
    {
        rastgel = Random.Range(0, 10);
        if (kalpmi == true) { if (rastgel > 2) { Destroy(gameObject); } }
        player = GameObject.Find("player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            if (kalpmi == false) {
                Instantiate(efekt, transform.position + new Vector3(0, 1, 0), transform.rotation);
                Destroy(gameObject);
            }
            if (kalpmi == true)
            {
                if (player.GetComponent<ziplamaci>().can < 3) {
                    Instantiate(efekt, transform.position + new Vector3(0, 1, 0), transform.rotation);
                    Destroy(gameObject);
                }
                
            }

        }
    }
    void Update()
    {
        transform.Rotate(0, 1, 0);
    }
}
