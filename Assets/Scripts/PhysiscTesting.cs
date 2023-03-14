using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysiscTesting : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(gameObject.transform.forward.normalized * 2000 ,ForceMode.Force);
       
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
