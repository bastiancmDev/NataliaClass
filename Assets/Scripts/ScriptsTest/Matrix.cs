using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Pref;
    public float[,] PosMatrix;


    void Starta()
    {

        PosMatrix = new float[100, 100];

        for (int i = 0; i < PosMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < PosMatrix.GetLength(1); j++)
            {
                float clampX =(i / 100f);
                float clampY =(j / 100f);
                PosMatrix[i, j] = Mathf.PerlinNoise(clampX * 6, clampY * 6);
            }
        }



        for (int i = 0; i < PosMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < PosMatrix.GetLength(1); j++)
            {
                var game = Instantiate(Pref);
                game.transform.position = new Vector3(i, PosMatrix[i, j] * 100, j);
                
            }
        }







    }

    // Update is called once per frame
    
}
