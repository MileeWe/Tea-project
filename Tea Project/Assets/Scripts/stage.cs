using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage : MonoBehaviour
{
    public int stageNumber = 0;
    public GameObject boiling;
    public GameObject poinZero;
    void Start()
    {
        
    }
    void Update()
    {
        if (stageNumber==0)
        {
            Instantiate(boiling, poinZero.transform.position, Quaternion.identity);
            //GetComponent<Boiling>
        }
    }
}
