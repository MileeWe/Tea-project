using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    /*struct Object
    {
        public bool weed;
        public bool boil;
        public bool krot;
    }
    void Start()
    {
        //****Saving****\\
        Object Example = new Object();

        Example.weed = false;
        Example.boil = false;
        Example.krot = false;

        //****Loading****\\
        PlayerPrefs.SetString("Quest",JsonUtility.ToJson(Example));
    }*/

    class Salo
    {
        public bool weed = false;
        public bool boil = false;
        public bool krot = false;
    }

    void Start()
    {
        string json = JsonUtility.ToJson("Salo");

        Salo weed = JsonUtility.FromJson<Salo>(json);
    }
    public void classS()
    {
           
    }
}