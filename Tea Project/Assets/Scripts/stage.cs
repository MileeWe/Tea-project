using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage : MonoBehaviour
{
    public int stageNumber = 0;
    public GameObject boiling;
    public GameObject poinZero;
    public bool kittleExists = false;
    public bool boilingProgrss = false;
    public GameObject boilingProcess;
    public GameObject kittleGO;
    void Start()
    {
        boilingProcess.SetActive(false);
    }
    void Update()
    {
        if (stageNumber==0)
        {

        }
        if (stageNumber==1)
        {
            kittleGO = GameObject.Find("kittle(Clone)");
            boilingProcess.SetActive(true);
            if (!kittleExists)
            {
                Instantiate(boiling, poinZero.transform.position, Quaternion.identity, poinZero.transform);
                kittleExists = true;
            }
            if (boilingProgrss)
            {
                stageNumber++;
            }
        }
        else
        {
            boilingProcess.SetActive(false);
            Destroy(kittleGO);
        }
    }
    public void boilingBool()
    {
        boilingProgrss = true;
    }
}