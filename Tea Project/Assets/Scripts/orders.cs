using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orders : MonoBehaviour
{
    public Text text;
    int tea = Random.Range(0, 1);
    int sugar = Random.Range(0, 6);
    int extra_travka = Random.Range(0, 2);
    void Start()
    {
        
    }

    void Update()
    {
        if (tea == 1) text.text = "tea" + " ";
        else text.text = "coffee" + " ";
        text.text += $"{sugar} sugar" + " ";
        if (extra_travka == 0) text.text += "milk" + " ";
        if (extra_travka == 1) text.text = "1 travka" + " ";
        if (extra_travka == 2) text.text = "2 travka" + " ";


    }
}
