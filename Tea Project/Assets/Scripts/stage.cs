using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage : MonoBehaviour
{
    public GameObject not_aaaa;
    public Animator aaaa;
    public int stageNumber;
    public GameObject boiling;
    public GameObject poinZero;
    public bool kittleExists = false;
    public bool boilingProgrss = false;
    public GameObject boilingProcess;
    public GameObject kittleGO;
    public GameObject cup;
    void Start()
    {
        aaaa = not_aaaa.GetComponent<Animator>();
        kittleGO = GameObject.Find("kittle(Clone)");
        boilingProcess.SetActive(false);
    }
    void Update()
    {
        //if (!kittleExists)
        //{
        //    Instantiate(boiling, poinZero.transform.position, Quaternion.identity, poinZero.transform);
        //    kittleExists = true;
        //}
        //это нада не трожь switch (stage)
        if (stageNumber==1)
        {
            boilingProcess.SetActive(true);
            
            if (Input.GetKey(KeyCode.S)&& Input.GetKey(KeyCode.LeftControl)&&Input.GetKey(KeyCode.RightShift))
            {
                stageNumber++;
            }
        }
        else
        {
            boilingProcess.SetActive(false);
        }
        if (stageNumber == 2)
        {
            SceneManager.LoadScene("mumble");
        }

    }
    public void boilingBoolTrue()
    {
        boilingProgrss = true;
    }    
    public void boilingBoolFalse()
    {
        boilingProcess.SetActive(false);
        stageNumber = 0;
        aaaa.SetBool("tea", true);
    }
    //public void travka()
    //{
    //    stageNumber = 2;
    //}
}

    
