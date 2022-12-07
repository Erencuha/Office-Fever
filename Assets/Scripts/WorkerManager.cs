using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WorkerManager : MonoBehaviour,IInteractable
{
    [SerializeField]List<GameObject> paperList=new List<GameObject>();
    public List<GameObject> moneyList = new List<GameObject>();
    [SerializeField] Transform paperPoint;
    [SerializeField] Transform moneyposition;
    [SerializeField] GameObject paperPrefab,moneyPrefab;
    private GameObject toppaper;
    public PrinterManager collect;
    public int money;
    


    private void Start()
    {
        collect = FindObjectOfType<PrinterManager>();
        StartCoroutine(GetMoney());
    }

    public void GetPaper()
    {

        toppaper = collect.playerPaperList[collect.playerPaperList.Count - 1];
        float paperCount = paperList.Count * 0.017f;
        collect.playerPaperList.Remove(toppaper);
        paperList.Add(toppaper);
        toppaper.transform.parent = paperPoint;

        var dest = new Vector3(paperPoint.position.x, paperPoint.position.y+paperCount, paperPoint.position.z);
        var paperRot = paperPoint.rotation;
        toppaper.transform.rotation = paperRot;
        toppaper.transform.DOMove(dest, 0.2f);




    }

    public void Interact()
    {
        GetPaper();
    }


   
    IEnumerator GetMoney()
    {
        while (true)
        {

            if (paperList.Count>0)
            {





                float moneyCount = moneyList.Count * 0.043f;
                GameObject temp = Instantiate(moneyPrefab);
                temp.transform.position = new Vector3(moneyposition.position.x, moneyposition.position.y + moneyCount, moneyposition.position.z);
                moneyList.Add(temp);
                RemoveLast();
            }
           
            
          
            yield return new WaitForSeconds(1.1f);
        }
        

       
    }
    public void RemoveLast()
    {
        Destroy(paperList[paperList.Count - 1]);
        paperList.RemoveAt(paperList.Count - 1);

    }

}
