using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class etrafindadon : MonoBehaviour
{
    public Vector3 v = Vector3.forward * 1.5f;
    public Vector3 axis = Vector3.up;
    float orbitSpeed = 90;
    Rigidbody rigid;
    public Transform ship;
    public bool esas = false;
    void Start()
    {
        if (esas == false) { rigid = gameObject.GetComponent<Rigidbody>(); }
        if (esas == true) { transform.position = transform.position + new Vector3(0,8, 0); }
        //ship = GameObject.FindWithTag("Plane").transform;
    }

    void FixedUpdate()
    {
        if (esas == false) {
            v = Quaternion.AngleAxis(orbitSpeed * Time.fixedDeltaTime, axis) * v;
            rigid.MovePosition(ship.position + v);
        }
        
    }
}
