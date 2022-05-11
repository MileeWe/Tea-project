using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salo
{
    public bool weed = false;
    public bool boil = false;
    public bool krot = false;
}
public class SaveLoad : MonoBehaviour
{
    public Salo obj;
    public string json;
    void Start()
    {
        json = PlayerPrefs.GetString("AMOGUS", "def");
        if (json != "def") obj = JsonUtility.FromJson<Salo>(json);
        else obj = new Salo();
        json = JsonUtility.ToJson(obj);
        //Debug.Log(json);
        PlayerPrefs.SetString("AMOGUS", json);
    }
    public void classS()
    {
           
    }
}