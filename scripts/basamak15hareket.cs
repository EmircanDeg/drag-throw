using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basamak15hareket : MonoBehaviour
{
    
    float hiz;
    bool asagi=false;
    Rigidbody rigid;
    
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        hiz = Random.Range(2500, 6000);
    }

    // Update is called once per frame
    void Update()
    {
        if (asagi == false) { /*transform.position = transform.position + new Vector3(0, 1, 0) * Time.deltaTime * hiz;*/ rigid.AddForce(0,hiz,0); asagi = true; }
        /*if (asagi == true) { transform.position = transform.position + new Vector3(0, -1, 0) * Time.deltaTime * hiz; }*/
        
    }
    private void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.tag == "yukari") { asagi = true; }*/
        if (other.gameObject.tag == "asagi") { rigid.velocity = Vector3.zero; asagi = false; hiz = Random.Range(2050,6000); }
    }
}
