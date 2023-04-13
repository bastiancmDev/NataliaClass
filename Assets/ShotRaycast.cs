using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (true)
            {
                Debug.Log(Vector3.Distance(transform.position, hit.transform.position));
                //LineRenderer(transform.position, hit.point);
                var line = gameObject.GetComponent<LineRenderer>();
                Vector3[] positions = { transform.position, hit.point };
                line.SetPositions(positions);
               
            }
            

        }

    }
}
