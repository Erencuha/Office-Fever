using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PrinterManager : MonoBehaviour,IInteractable
{
    public List<GameObject> paperList = new List<GameObject>();
    public List<GameObject> playerPaperList = new List<GameObject>();
    int paperLimit = 30;
    public GameObject paperPrefabs;
    public Transform exitPoint;
    bool iswWorking;

    public Transform collectPoint;

    void Start()
    {
        StartCoroutine(PrintPaper());
    }

    public void RemoveLast()
    {
        //Destroy(paperList[paperList.Count - 1]);
        paperList.RemoveAt(paperList.Count - 1);
       

    }
    IEnumerator PrintPaper()
    {

        while (true)
        {
            if (iswWorking)
            {
                float paperCount = paperList.Count * 0.017f;
                GameObject temp = Instantiate(paperPrefabs,exitPoint);
                temp.transform.position = new Vector3(exitPoint.position.x, exitPoint.position.y + paperCount, exitPoint.position.z);
                paperList.Add(temp);
            
               
                if (paperList.Count >= 30)
                {
                    iswWorking = false;
                }
            }
            else if(paperList.Count<30)
            {
                iswWorking=true;
            }
            yield return new WaitForSeconds(1.1f);
        }

    }
    public void Interact()
    {
        if (playerPaperList.Count <= paperLimit)
        {
            var toppaper = paperList[paperList.Count - 1];

            float paperCount = paperList.Count * 0.017f;
            var dest = new Vector3(collectPoint.localPosition.x, collectPoint.localPosition.y + paperCount, collectPoint.localPosition.z);
            toppaper.transform.DOLocalMove(dest, 0.2f);
            playerPaperList.Add(toppaper);
            toppaper.transform.parent = collectPoint;
            var paperRot = collectPoint.rotation;
            toppaper.transform.rotation = paperRot;
            //GameObject temp = Instantiate(paperPrefab, collectPoint);
            //temp.transform.position=new Vector3(collectPoint.position.x, collectPoint.position.y+paperCount, collectPoint.position.z);
            //paperList.Add(temp);
            //if (TriggerManager.printerManager != null)
            //{
            //    TriggerManager.printerManager.RemoveLast();
            //}
            RemoveLast();
        }
    }

    public void PlayerRemoveLast()
    {
        //Destroy(paperList[paperList.Count - 1]);
        playerPaperList.RemoveAt(playerPaperList.Count - 1);


    }


}
