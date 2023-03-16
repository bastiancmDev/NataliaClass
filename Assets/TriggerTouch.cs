using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerTouch : MonoBehaviour, InteractiveObject
{
    // Start is called before the first frame update

    public GameObject DialogPb;

    private void OnTriggerEnter(Collider other)
    {
        CreateDialogSystem();
    }


    public void SendMsg()
    {


    }

    public void CreateDialogSystem()
    {
        GameObject currentDialog = Instantiate(DialogPb);
        DigalogViewModel currentDialogVM = currentDialog.GetComponent<DigalogViewModel>();
        currentDialogVM.SetUp("NUEVO TITULO DE LA VENTANA", "NUEVA DESCRIPCION DE LA VENTANA");
        DigalogView currentView = currentDialog.GetComponent<DigalogView>();
        currentView.SetInfo(currentDialogVM);
    }
}

