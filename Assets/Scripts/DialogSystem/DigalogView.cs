using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigalogView : MonoBehaviour
{
    public Text Title;
    public Text Description;
    public Image Imagen;


    public void SetInfo(DigalogViewModel dialogViewModel)
    {
        this.Title.text = dialogViewModel.Title;
        this.Description.text = dialogViewModel.Description;
        this.Imagen = dialogViewModel.Imagen;
    }

    public void CloseView()
    {
        Destroy(gameObject);
    }
   
}
