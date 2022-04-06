using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseEnter : MonoBehaviour
{
    public GameObject boilong;
    void Start()
    {
        Physics.queriesHitTriggers = true;
    }
    void OnMouseEnter()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            boilong.SetActive(true);
            Debug.Log("fsdfsd");
        }
    }
    private void Update()
    {
        //if (Input.GetKey(KeyCode.Mouse0))
        //{
            
        //}
    }
}
