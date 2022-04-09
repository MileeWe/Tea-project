using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class combinations : MonoBehaviour
{
    //public int[] combin = new int[5];
    public int i = 0;
    public randomSpec RandomSpec;
    public int[] combin = new int[4];
    void Start()
    {
        /*for (int i = 0; i < combin.Length; i++)
        {
            int rd = UnityEngine.Random.Range(1, 9);
            combin[i] = rd;
            
        }*/
        combin = create();
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

    public int[] create()
    {
        int[] area = new int[4];
        area[0] = UnityEngine.Random.Range(0, 9);
        int i = 0;
        while (true)
        {
            if (i == 0)
            {
                area[1] = UnityEngine.Random.Range(0, 9);
                i++;
            }
            else
            {
                if (area[1] == area[0])
                {
                    area[1] = UnityEngine.Random.Range(0, 9);
                }
                else
                {
                    break;
                }
            }
        }
        while (true)
        {
            if (i == 0)
            {
                area[2] = UnityEngine.Random.Range(0, 9);
                i++;
            }
            else
            {
                if (area[2] == area[0] || area[2] == area[1])
                {
                    area[2] = UnityEngine.Random.Range(0, 9);
                }
                else
                {
                    break;
                }
            }
        }
        while (true)
        {
            if (i == 0)
            {
                area[3] = UnityEngine.Random.Range(0, 9);
                i++;
            }
            else
            {
                if (area[3] == area[0] || area[3] == area[1] || area[3] == area[2])
                {
                    area[3] = UnityEngine.Random.Range(0, 9);
                }
                else
                {
                    break;
                }
            }
        }
        while (true)
        {
            if (i == 0)
            {
                area[4] = UnityEngine.Random.Range(0, 9);
                i++;
            }
            else
            {
                if (area[4] == area[0] || area[4] == area[1] || area[4] == area[2] || area[4] == area[3])
                {
                    area[4] = UnityEngine.Random.Range(0, 9);
                }
                else
                {
                    break;
                }
            }
        }
        return area;
    }
}
