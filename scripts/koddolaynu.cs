using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koddolaynu : MonoBehaviour
{
    Vector3 startPos;
    Vector3 endPos;
    public LineRenderer lr;
    public float z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camOffset = new Vector3(0,0,z);
        if(Input.GetMouseButtonDown(0)){
            lr.enabled=true;
            lr.positionCount=2;
            startPos = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane))+camOffset;
            lr.SetPosition(0,startPos);
            lr.useWorldSpace=true;
        }
        if(Input.GetMouseButtonUp(0)){
            lr.enabled = false;
        }
        if(Input.GetMouseButton(0)){
            endPos = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane))+camOffset;
            lr.SetPosition(1,endPos);
        }
        
    }
}
