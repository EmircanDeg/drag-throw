using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summoncuscript : MonoBehaviour
{
    public GameObject[] cikacaklar;
    public GameObject cikaricitetik;
    public GameObject bulut;
    int secim;
    public GameObject player;
    int say = 0;
    public GameObject kar;
    int checkpointmi = 0;
    public GameObject cekpoint;
    void Start()
    {
        player = GameObject.Find("player");
    }

    public void cikart()
    {
        if(transform.position.x-player.transform.position.x < 60)
        {
            
            if (checkpointmi < 25) {
                secim = Random.Range(0, cikacaklar.Length);
                Instantiate(cikacaklar[secim], transform.position, transform.rotation);
                Instantiate(bulut, transform.position, transform.rotation);
                Instantiate(cikaricitetik, transform.position + new Vector3(0, 75, 0), transform.rotation);
                transform.position = transform.position + new Vector3(10, 2, 0);
                say++;
                if (say == 6) { Instantiate(kar, transform.position, transform.rotation); say = 0; }
                checkpointmi++;
            }
            if (checkpointmi == 25) {
                //secim = Random.Range(0, cikacaklar.Length);
                Instantiate(cekpoint, transform.position, transform.rotation);
                Instantiate(bulut, transform.position, transform.rotation);
                Instantiate(cikaricitetik, transform.position + new Vector3(0, 75, 0), transform.rotation);
                transform.position = transform.position + new Vector3(10, 2, 0);
                say++;
                if (say == 6) { Instantiate(kar, transform.position, transform.rotation); say = 0; }
                checkpointmi=0;
            }
        }
        Debug.Log(checkpointmi);
    }
    void Update()
    {
        
    }
}
