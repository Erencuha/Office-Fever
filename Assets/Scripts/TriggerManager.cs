using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public delegate void OnCollectArea();
    public static event OnCollectArea OnPaperCollect;
    public delegate void OnDeskArea();
    public static event OnDeskArea OnPaperGive;


    public delegate void OnMoneyArea();
    public static event OnMoneyArea OnMoneyCollected;

    public delegate void OnBuyArea();
    public static event OnBuyArea OnBuyingDesk;


    [SerializeField] bool isCollecting,isGiving;

    public static WorkerManager workerManager;
    public static PrinterManager printerManager;


   

    private void OnTriggerEnter(Collider other)
    {
       
    }
    private void OnTriggerStay(Collider other)
    {

        IInteractable interactable = other.gameObject.GetComponent<IInteractable>();
        if (interactable!=null)
        {
            interactable.Interact();
        }




       
    }

}
