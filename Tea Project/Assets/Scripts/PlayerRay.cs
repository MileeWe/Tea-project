using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class PlayerRay : MonoBehaviour
{
    void Start()
    {
    }
    

    void Update()
    {
        //выводит имя объекта при нажатии
        if (Input.GetMouseButtonDown(0))
        {
            string a = "ban";
            RaycastHit hit;
            Ray ray;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                    a = hit.transform.gameObject.name;
                }
                if (a == "kittle(Clone)")
                {
                    //нужен переход на stage
                    //GetComponent<stage>().boilingBool();
                }
            }
        } 
    }
    void PrintName(GameObject go)
    {
        Debug.Log((go.name));
    }

    /*bool asas()
    {
        
        string ass = "ban";
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                    ass = hit.transform.gameObject.name;
                }
            }
        }
        return (ass == "kittle(Clone)");
    }*/

}