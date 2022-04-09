using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orders : MonoBehaviour
{
    public static string marijuana;
    public int sugar;
    public int strength;
    bool a;
    public Text orderText;
    public GameObject canvas;
    public NpcMove aaaaa;


    private void Start()
    {
        canvas.SetActive(false);
        int rd = Random.Range(1,6);
        switch (rd)
        {
            case 1:
                marijuana = "green";
                break;
            case 2:
                marijuana = "red";
                break;
            case 3:
                marijuana = "yellow";
                break;
            case 4:
                marijuana = "orange";
                break;
            case 5:
                marijuana = "beb";
                break;
        }
        int fichaRd = Random.Range(0,1000);
        if (fichaRd == 666)
        {
            a = true;
        }
        rd = Random.Range(0,4);
        sugar = rd;
        rd = Random.Range(1,10);
        strength = rd;
        orderText.text = $"Make me tea with {marijuana} weed, with {sugar} spoons of sugar and strength {strength}";
        
    }
    void Update()
    {
        if (aaaaa.text)
        {
            Debug.Log("ggg");
            canvas.SetActive(true);
        }
    }
    public void GameOver()
    {
        orderText.text = $"Game over bitch";
        canvas.SetActive(true);
    }
}
