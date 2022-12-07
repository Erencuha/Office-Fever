using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CollectManager : MonoBehaviour
{
    //public List<GameObject> paperList=new List<GameObject> ();
    //public GameObject paperPrefab;
    //public Transform collectPoint; 
    //int paperLimit=30;

    //public PrinterManager printer;
    //void Start()
    //{
    //    printer=FindObjectOfType<PrinterManager>();
    //}

    //private void OnEnable()
    //{
    //    TriggerManager.OnPaperCollect += GetPaper;
    //    TriggerManager.OnPaperGive += GivePaper;
    //}
    //private void OnDisable()
    //{
    //    TriggerManager.OnPaperCollect -= GetPaper;
    //    TriggerManager.OnPaperGive -= GivePaper;
    //}

    void GetPaper()
    {
       
    }
    
   //public void etkiles()
   // {
   //     if (paperList.Count <= paperLimit)
   //     {
   //         var toppaper = printer.paperList[printer.paperList.Count - 1];

   //         float paperCount = paperList.Count * 0.017f;
   //         var dest = new Vector3(collectPoint.localPosition.x, collectPoint.localPosition.y + paperCount, collectPoint.localPosition.z);
   //         toppaper.transform.DOLocalMove(dest, 0.2f);
   //         paperList.Add(toppaper);
   //         toppaper.transform.parent = collectPoint;
   //         var paperRot = collectPoint.rotation;
   //         toppaper.transform.rotation = paperRot;
   //         //GameObject temp = Instantiate(paperPrefab, collectPoint);
   //         //temp.transform.position=new Vector3(collectPoint.position.x, collectPoint.position.y+paperCount, collectPoint.position.z);
   //         //paperList.Add(temp);
   //         if (TriggerManager.printerManager != null)
   //         {
   //             TriggerManager.printerManager.RemoveLast();
   //         }
   //     }
   // }

   // void GivePaper()
   // {
   //     if (paperList.Count>0)
   //     {
   //         TriggerManager.workerManager.GetPaper();
   //         RemoveLast();


   //     }
   // }
   // public void RemoveLast()
   // {
   //     Destroy(paperList[paperList.Count - 1]);
   //     paperList.RemoveAt(paperList.Count - 1);

   // }

}
