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
    public GameObject cup;
    void Start()
    {
        boilingProcess.SetActive(false);
        cup.gameObject.SetActive(false);//tyt_kakaya-to_xren'_s_inspectorom_v_stage_chekni_pls:D
    }
    void Update()
    {
        if (stageNumber==0)
        {
            kittleGO = GameObject.Find("kittle(Clone)");
            if (Input.anyKey)
            {
                boilingProcess.SetActive(true);
                boilingProgrss = true;
            }
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
        }
        if (stageNumber == 1)
        {
            kittleGO = GameObject.Find("Tea_Cup");
        }

    }
    public void boilingBool()
    {
        boilingProgrss = true;

    }
}

    
