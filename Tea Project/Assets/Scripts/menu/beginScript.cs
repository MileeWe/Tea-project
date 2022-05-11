using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginScript : MonoBehaviour
{
    public class Salo
    {
        public bool weed = false;
        public bool boil = false;
        public bool krot = false;
    }
    public Salo obj;
    public string json = "def";

    void Start()
    {
        //obj = new Salo();
        //json = JsonUtility.ToJson(obj);
        ////Debug.Log(json);
        //PlayerPrefs.SetString("AMOGUS", json);
        //PlayerPrefs.SetString("NPC_cord", json);
        //PlayerPrefs.SetString("NPC_rotate", json);
        PlayerPrefs.DeleteAll();
    }
    void Update()
    {

    }
}
