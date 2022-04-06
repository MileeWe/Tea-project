using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boiling : MonoBehaviour
{
    public stage suck;
    public Slider boil;
    public bool target = false;
    public float maxBoilInter = 200;
    public int rd;
    public Transform boilTrans;
    public Slider boilTwo;
    public GameObject pointZero;
    public bool direction = false;
    public bool reer = false;
    public NpcMove kek;
    void Start()
    {
        rd = Random.Range(25,170);
        boilTwo.maxValue = 200;
        boil.maxValue = 200;
        boilTwo.value = rd;
        boil.value = 0;
        Screen.SetResolution(1920, 1080, true);
    }
    public void FF()
    {
        target = true;
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
            pointZero.GetComponent<orders>().GameOver();
        }
        if (boil.value > (rd-10)&&boil.value<(rd+10)&&target)
        {
            suck.stageNumber = 0;
            suck.boilingProcess.SetActive(false);
            reer = true;
            //pointZero.GetComponent<stage>().Anima();

        }
        else if (target)
        {
            pointZero.GetComponent<orders>().GameOver();
        }
    }
}