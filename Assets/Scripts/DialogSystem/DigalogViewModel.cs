using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigalogViewModel : MonoBehaviour
{
    public string Title;
    public string Description;
    public AudioClip ClipAudio;
    public Image Imagen;


    public void SetUp(string title, string description)
    {
        Title = title;
        Description = description;
    }

}
