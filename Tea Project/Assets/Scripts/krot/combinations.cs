using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class combinations : MonoBehaviour
{
    public int i = 0;
    public randomSpec RandomSpec;
    public int[] combin = new int[4] { 3, 4, 5, 6 };
    void Start()
    {
        //combin = createArea(4);
        //combin = { 3,4,5,6 };
        StartCoroutine("krot");
    }

    IEnumerator krot()
    {
        
        while (true)
        {
            if (i<9)
            {
                GameObject sphere = GameObject.Find(Convert.ToString(combin[i]));
                //GetComponent<Renderer>().material.color = Color.black;
                sphere.gameObject.GetComponent<Selecta>().black();
                i++;
            }
            else
            {
                StopCoroutine("krot");
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    public int[] createArea(int n)
    {
        int[] area = new int[n];
        for (int i = 0; i < area.Length; i++)
        { 
            while (true)
            {
                area[i] = UnityEngine.Random.Range(0, 9);
                if (!SearchMatches(area, area[i]))
                {
                    break;
                }
            }
            
        }
        return area;
    }
    public bool SearchMatches(int[] area, int n)
    {
        for (int i = 0; i < area.Length; i++)
        {
            if (area[i] == n)
            {
                return true;
            }
        }
        return false;
    }
}
