using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.right * 9, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
