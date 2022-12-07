using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour,IInteractable
{
  public float moneyAmount;
    public WorkerManager workerManager;

    private void Start()
    {
           workerManager=FindObjectOfType<WorkerManager>();
    }
    public void Interact()
    {
        workerManager.money += 50;
        Destroy(gameObject);
    }
}
