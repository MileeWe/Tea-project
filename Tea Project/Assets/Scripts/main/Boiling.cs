using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Text.Json;
//using System.Text.Json.Serialization;

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
    public GameObject qest;
    public string json;
    public Salo obj;
    public bool load;
    public string npc;
    void Start()
    {
        json = PlayerPrefs.GetString("AMOGUS", "def");
        rd = Random.Range(25,170);
        boilTwo.maxValue = 200;
        boil.maxValue = 200;
        boilTwo.value = rd;
        boil.value = 0;
        Screen.SetResolution(1920, 1080, true);

        //string json = JsonUtility.ToJson(kek);
        //PlayerPrefs.SetString("AMOGUS", json);
        //NpcMove myObject = JsonUtility.FromJson<NpcMove>(json);
        //string st = PlayerPrefs.GetString("AMOGUS", "def");

        //kek = JsonUtility.FromJson<NpcMove>(PlayerPrefs.GetString("AMOGUS", "def"));
        Debug.Log(json);
    }
    public void FF()
    {
        target = true;
    }

    void Update()
    {
        obj = JsonUtility.FromJson<Salo>(json);
        // string json = JsonUtility.ToJson(FF);
        //string st = PlayerPrefs.GetString("AMOGUS", "def");
        //if (st == "def") Debug.Log("lox");
        //else Debug.Log("vse ravno lox");
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
            obj.boil = true;
            //reer = true;
            //pointZero.GetComponent<stage>().Anima();

        }
        else if (target)
        {
            pointZero.GetComponent<orders>().GameOver();
        }
        npc = JsonUtility.ToJson(kek);
        json = JsonUtility.ToJson(obj);
        Debug.Log(json);
        PlayerPrefs.SetString("AMOGUS", json);
        PlayerPrefs.SetString("NPC_SAVE", npc);
    }
}