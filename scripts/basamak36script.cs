using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basamak36script : MonoBehaviour
{
    float y;
    void Start()
    {
        y = transform.position.y;
        transform.position = new Vector3(transform.position.x, y + 40, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < y - 40) { transform.position = new Vector3(transform.position.x, y + 40, transform.position.z);gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero; gameObject.GetComponent<Rigidbody>().AddForce(0,-200,0); }
    }
}
