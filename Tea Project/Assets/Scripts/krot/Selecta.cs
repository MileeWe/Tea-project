using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecta : MonoBehaviour
{
    public void Select()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    public void Deselect()
    {
        GetComponent<Renderer>().material.color = Color.gray;
    }
    public void black()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
}
