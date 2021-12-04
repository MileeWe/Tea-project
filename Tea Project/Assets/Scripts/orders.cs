using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orders : MonoBehaviour
{
    void Start()
    {
        
    }
    /*public Text text;
    public float tea;
    public float sugar;
    public float extra_travka;
    public float tea_count;
    public float sugar_count;
    public float extra_travka_count;
    public int stage;

    void Start()
    {
        Order();
        Debug.Log(tea);
        Debug.Log(sugar);
        Debug.Log(extra_travka);
        tea_count = tea;
        sugar_count = sugar;
        extra_travka_count = extra_travka;
        Debug.Log(tea_count);
        Debug.Log(sugar_count);
        Debug.Log(extra_travka_count);
        StartCoroutine(time());
        if ((Input.GetKey(KeyCode.Mouse0))& (stage == 2)) sugar_count++;
    }
    IEnumerator time()
    {
         while(true)
         {
            yield return new WaitForSeconds(10);
            if ((tea == tea_count) && (extra_travka == extra_travka_count) && (sugar == sugar_count)) Order();
            Debug.Log(tea);
            Debug.Log(sugar);
            Debug.Log(extra_travka);
         }

    }

    void Update()
    {
        if (tea == 1) text.text = "tea" + " ";
        else text.text = "coffee" + " ";
        text.text += $"{sugar} sugar" + " ";
        if (extra_travka == 0) text.text += "milk" + " ";
        if (extra_travka == 1) text.text += "1 travka" + " ";
        if (extra_travka == 2) text.text += "2 travka" + " "; 

    }
    public void Order()
    { 
        tea = Random.Range(0, 2);
        sugar = Random.Range(0, 7);
        extra_travka = Random.Range(0, 3);

    }*/
}
