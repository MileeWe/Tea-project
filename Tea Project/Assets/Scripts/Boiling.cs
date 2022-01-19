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
        boil.maxValue = 200;
        boil.value = 0;
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
            boil.value += 0.1f;
        }
        if (direction && !target)
        {
            pointZero.GetComponent<stage>().nextStage();
        }
    }
}