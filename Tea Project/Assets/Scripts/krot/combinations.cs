using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class combinations : MonoBehaviour
{
    public int[] combin = new int[5];
    public int i = 0;
    void Start()
    {
        for (int i = 0; i < combin.Length; i++)
        {
            int rd = UnityEngine.Random.Range(1, 9);
            combin[i] = rd; 
        }
        StartCoroutine("krot");
    }

    IEnumerator krot()
    {

        while (true)
        {
            if (i<combin.Length)
            {
                GameObject sphere = GameObject.Find(Convert.ToString(combin[i]));
                sphere.GetComponent<Renderer>().material.color = Color.black;
                i++;
            }
            else
            {
                StopCoroutine("krot");
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
