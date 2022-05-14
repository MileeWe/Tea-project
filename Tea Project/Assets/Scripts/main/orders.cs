using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orders : MonoBehaviour
{
    public class ya_xz_kak_nazvat
    {
        public string marijuana;
        public int sugar;
        public int strength;
    }
    public string marijuana;
    bool a;
    public Text orderText;
    public GameObject canvas;
    public NpcMove aaaaa;
    public ya_xz_kak_nazvat nazval;
    public string spasi_i_soxrani;

    private void Start()
    {
        nazval = new ya_xz_kak_nazvat();
        spasi_i_soxrani = PlayerPrefs.GetString("order", "def");
        if (spasi_i_soxrani != "def") 
        {   
            nazval = JsonUtility.FromJson<ya_xz_kak_nazvat>(spasi_i_soxrani);
            spasi_i_soxrani = JsonUtility.ToJson(nazval);
            PlayerPrefs.SetString("order", spasi_i_soxrani);
        }
        else
        {
            canvas.SetActive(false);
            int rd = Random.Range(1, 6);
            switch (rd)
            {
                case 1:
                    nazval.marijuana = "green";
                    break;
                case 2:
                    nazval.marijuana = "red";
                    break;
                case 3:
                    nazval.marijuana = "yellow";
                    break;
                case 4:
                    nazval.marijuana = "orange";
                    break;
                case 5:
                    nazval.marijuana = "beb";
                    break;
            }
            int fichaRd = Random.Range(0, 1000);
            if (fichaRd == 666)
            {
                a = true;
            }
            rd = Random.Range(0, 4);
            nazval.sugar = rd;
            rd = Random.Range(1, 10);
            nazval.strength = rd;
            orderText.text = $"Make me tea with {nazval.marijuana} weed, with {nazval.sugar} spoons of sugar and strength {nazval.strength}";
            spasi_i_soxrani = JsonUtility.ToJson(nazval);
            PlayerPrefs.SetString("order", spasi_i_soxrani);
        }// я знаю что написал говно 
        // отстань
    }
    void Update()
    {
        if (aaaaa.text)
        {
            Debug.Log("ggg");
            canvas.SetActive(true);
        }//^ a ono nam nado?^
    }
    public void GameOver()
    {
        orderText.text = $"Game over bitch";
        canvas.SetActive(true);
    }
}
