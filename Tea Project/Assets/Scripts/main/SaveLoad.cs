using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public string weed = "false";
    public GameObject f;
    public bool boil = false;
    public bool krot = false;
    void Start()
    {
        string weedJ = JsonUtility.ToJson(f);
        string boilJ = JsonUtility.ToJson(boil);
        string krotJ = JsonUtility.ToJson(krot);

        PlayerPrefs.SetString("weed", weedJ);
        PlayerPrefs.SetString("boil", boilJ);
        PlayerPrefs.SetString("krot", krotJ);

        Debug.Log(PlayerPrefs.GetString("weed", "def"));
    }
}
