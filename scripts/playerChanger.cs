using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

//void OnTriggerEnter(Collider other)

    private void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "Player"){
            Destroy(GameObject.FindWithTag("Player"));
            gameObject.tag="Player";
            string ScriptName = "ziplamaci";
            System.Type MyScriptType = System.Type.GetType(ScriptName + ",Assembly-CSharp");
            gameObject.AddComponent(MyScriptType);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
