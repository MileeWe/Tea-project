using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }
    void Update()
    {
        //это нада не трожь switch (stage)
        if (stageNumber==0)
        {
            kittleGO = GameObject.Find("kittle(Clone)");
            if (Input.anyKey)
            {
                boilingProcess.SetActive(true);
            }
            if (!kittleExists)
            {
                Instantiate(boiling, poinZero.transform.position, Quaternion.identity, poinZero.transform);
                kittleExists = true;
            }
            if (Input.GetKey(KeyCode.S)&& Input.GetKey(KeyCode.LeftControl)&&Input.GetKey(KeyCode.RightShift))
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
            SceneManager.LoadScene("mumble"); 
        }

    }
    public void boilingBool()
    {
        boilingProgrss = true;
    }    
    public void nextStage()
    {
        stageNumber++;
    }
}

    
