using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boiling : MonoBehaviour
{
    public Slider boil;
    public bool target = false;
    public float maxBoilInter = 200;
    public int rd;
    public Transform boilTrans;
    public GameObject prefab;
    public GameObject canvas;
    public GameObject pointZero;
    public bool direction = false;
    void Start()
    {
        rd = Random.Range(-260, 260);
        transform.position = new Vector3(rd, 0, -2);
        Vector3 position = new Vector3(rd, 0, 0);
        //Quaternion qua = new Quaternion(0, 0, 0, 0);
        //Vector3 position = boilTrans.transform.position;
        //Debug.Log(boilTrans.transform.position);
        boil.maxValue = 200;
        boil.value = 0;
        /*rd = Random.Range(0, 180);
        position.x = Random.Range(200, 400);
        position = new Vector3(rd, position.y, 0);
        Instantiate(prefab, position, Quaternion.identity, canvas.transform);*/
        Screen.SetResolution(1920, 1080, true);
    }

    void Update()
    {
        if (boil.value == boil.maxValue)
        {
            direction = true;
        }
        if (boil.value == boil.minValue)
        {
            direction = false;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            target = true;
        }
        if (!direction && !target)
        {
            boil.value += 1f;
        }
        if (direction && !target)
        {
            Debug.Log("Game over");
            pointZero.GetComponent<stage>().boilingBool();
        }
        if (target & boil.value <= (rd + 10) & boil.value >=(rd-10))
        {
            pointZero.GetComponent<stage>().boilingBool();
        }
        else if (target)
        {
            Debug.Log("Game over");
        }
    }
}