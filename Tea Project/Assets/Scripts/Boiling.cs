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
    public Slider boilTwo;
    public Transform boilTrans;
    public GameObject prafab;
    public GameObject canvas;
    public GameObject pointZero;
    public bool direction = false;
    void Start()
    {
        Vector3 position = boilTrans.transform.position;
        Debug.Log(boilTrans.transform.position);
        boil.maxValue = 200;
        boil.value = 0;
        position.z = 3000;
        rd = Random.Range(0, 180);
        position.x = Random.Range(200, 400);
        boilTwo.value = rd;
        position = new Vector3(rd, position.y, position.z);
        Instantiate(prafab, position, Quaternion.identity, canvas.transform);
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
            boil.value += 0.2f;
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