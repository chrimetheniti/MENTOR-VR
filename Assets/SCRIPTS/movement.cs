using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
        
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
