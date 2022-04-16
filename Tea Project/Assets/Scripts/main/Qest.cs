using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Qest : MonoBehaviour
{
    public Text text;
    public bool weed = false;
    public bool boil = false;
    public bool krot = false;
    void Start()
    {
        text.text = "Weed quest\n" + "Boil quest\n" + "Strength quest\n";    
    }
    void Update()
    {
        if (weed)
        {

        }
    }
}
