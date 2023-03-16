using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorFromTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Door;
    public GameObject Target;
    public Vector3 InitialPositon;


    public void Start()
    {
        InitialPositon = gameObject.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name != "Door")
        {
            Debug.Log("Open the Door");
            StartCoroutine(SubirPuerta());
        }
       
    }


    private void OnTriggerExit(Collider other)
    {

        if (other.name != "Door")
        {
            Debug.Log("Close the Door");
            StopAllCoroutines();
            StartCoroutine(BajarPuerta());
        }

            
        
    }



    IEnumerator SubirPuerta()
    {
        float time = 0;
        while (true)
        {
            Door.transform.position = Vector3.Lerp(Door.transform.position, Target.transform.position, time);
            yield return new WaitForSeconds(.001f);
            time += 0.0001f;
            if (time >= 1) break;
        }
    }

    IEnumerator BajarPuerta()
    {

        float time = 0;
        while (true)
        {
            Door.transform.position = Vector3.Lerp(Door.transform.position, InitialPositon, time);
            yield return new WaitForSeconds(.001f);
            time += 0.0001f;
            if (time >= 1) break;
        }
    }



}
