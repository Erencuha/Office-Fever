using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed;
    public string sname;
    [SerializeField] private ScriptableObjectsTest type;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = type.color;
        sname=type.name;
        speed=type.speed;


    }

   
}
