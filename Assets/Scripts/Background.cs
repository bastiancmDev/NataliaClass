using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public Transform fondo1;
    public Transform fondo2;
    public Vector3 initialPositionFondo1;
    public Vector3 initialPositionFondo2;

    // Start is called before the first frame update
    void Start()
    {
        initialPositionFondo1 = fondo1.position;
        initialPositionFondo2 = fondo2.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(fondo1.position.x  < -35.7f || fondo2.position.x > 30.61f)
        {
            fondo1.position = initialPositionFondo1;
            fondo2.position = initialPositionFondo2;
        }
            
        fondo1.position = new Vector3(fondo1.position.x - 0.01f, fondo1.position.y, fondo1.position.z);
        fondo2.position = new Vector3(fondo2.position.x + 0.01f, fondo2.position.y, fondo2.position.z);
    }
}
