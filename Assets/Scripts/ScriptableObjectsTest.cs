using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Enemy Type",menuName ="Enemy Type")]
public class ScriptableObjectsTest : ScriptableObject
{
    public string typename = "Type";
    public float speed = 2f;
    public Color color = Color.red;

}
