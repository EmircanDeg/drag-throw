using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class ziplamaci : MonoBehaviour
{
    public int can = 3;
    public GameObject[] kalps;
    private GameObject skin;
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    private Rigidbody rb;
    private bool isShoot;
    bool hareketli = false;
    public bool pcmi = false;
    private float forceMultipler = 0.15f;
    Vector3 checkpoint;
    public LineRenderer lr;
    public float z;
    public float carp = 3f;
    public GameObject checkpointefekt;

    // Start is called before the first frame update
    void Start()
    {
        checkpoint = transform.position + new Vector3(0, 5, 0);
        rb = GetComponent<Rigidbody>();
        if (pcmi == true) { forceMultipler = forceMultipler * 3.333f;carp = 1; }
        //skin = transform.GetChild(1).gameObject;
        for (int i = 0; i < 18; i++) {
            if (transform.GetChild(1).GetChild(i).gameObject.activeSelf) {
                skin = transform.GetChild(1).GetChild(i).gameObject;
            }
        }
    }

    /*private void OnMouseDown(){
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp(){
        mouseReleasePos = Input.mousePosition;
        Shoot(mousePressDownPos-mouseReleasePos);
    }*/

    /*void OnCollisionEnter(Collision collision){
        isShoot = false;
    }*/

    void kalpkontorl()
    { 
        if (can == 3) { kalps[0].SetActive(true); kalps[1].SetActive(true); kalps[2].SetActive(true); }
        if (can == 2) { kalps[0].SetActive(false); kalps[1].SetActive(true); kalps[2].SetActive(true); }
        if (can == 1) { kalps[0].SetActive(false); kalps[1].SetActive(false); kalps[2].SetActive(true); }
        if (can == 0) { kalps[0].SetActive(false); kalps[1].SetActive(false); kalps[2].SetActive(false); }
        
    }

    void Shoot(Vector3 Force){
        if(isShoot)
            return;
        if (Force.y < 35*carp) 
        {   if (Force.x > 180 * carp) { Force.x = 180 * carp; }
            if (Force.x < -180 * carp) { Force.x = -180 * carp; }
            Debug.Log(Force);
            rb.AddForce(new Vector3(Force.x, Force.y + 35, 0) * forceMultipler);
        }
        if(Force.y>= 35 * carp) 
        {
            if (Force.x > 180 * carp) { Force.x = 180 * carp; }
            if (Force.x < -180 * carp) { Force.x = -180 * carp; }
            if (Force.y > 250 * carp) { Force.y = 250 * carp; }
            rb.AddForce(new Vector3(Force.x, Force.y + 35, 0) * forceMultipler);
            
        }
        if (Force.x > 0) { rb.AddTorque(0, 0, 1); }
        if (Force.x < 0) { rb.AddTorque(0, 0, -1); }
        isShoot = true;
    }

    void Update(){
        Vector3 camOffset = new Vector3(0,0,z);
        if(rb.velocity==Vector3.zero || hareketli == true)
        {
            isShoot = false;
            /*Animator animator1 = skin.GetComponent<Animator>();
            animator1.SetBool("velo", false);*/
        }else{
            isShoot = true;
            /*Animator animator2 = skin.GetComponent<Animator>();
            animator2.SetBool("velo", true);*/
        }

        if(Input.GetMouseButtonDown(0)){
            mousePressDownPos = Input.mousePosition;
            if(isShoot==false){
                mousePressDownPos = Input.mousePosition;
                lr.enabled=true;
                lr.positionCount=2;
                Vector3 startPos = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane))+camOffset;
                lr.SetPosition(0,startPos);
                lr.useWorldSpace=true;
            }
        }
        if(Input.GetMouseButtonUp(0)){
            if(isShoot==false){
                mouseReleasePos = Input.mousePosition;
                Shoot(mousePressDownPos-mouseReleasePos);
                lr.enabled = false;
            }
        }
        if(Input.GetMouseButton(0)){
            Vector3 endPos = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane))+camOffset;
            lr.SetPosition(1,endPos);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hareketli") { hareketli = true; }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "hareketli") { hareketli = true; }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "hareketli") { hareketli = false; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "olum") { transform.position = checkpoint;rb.velocity = Vector3.zero;can = can - 1;kalpkontorl(); }
        if (other.gameObject.tag == "kalp") { if (can < 3) { can = can + 1;kalpkontorl(); } }
        if (other.gameObject.tag == "checkpoint") { checkpoint = other.gameObject.transform.position + new Vector3(0, 7, 0);Instantiate(checkpointefekt,checkpoint+new Vector3(0,0,2),transform.rotation) ;  }
    }
}
