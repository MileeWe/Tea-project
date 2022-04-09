using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpec : MonoBehaviour
{
    public int[] create()
    {
        int[] area = new int[4];
        area[0] = Random.Range(0,9);
        int i = 0;
        while (true)
        {
            if (i==0)
            {
                area[1] = Random.Range(0, 9);
                i++;
            }
            else
            {
                if (area[1]==area[0])
                {
                    area[1] = Random.Range(0, 9);
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
                area[2] = Random.Range(0, 9);
                i++;
            }
            else
            {
                if (area[2] == area[0]||area[2]==area[1])
                {
                    area[2] = Random.Range(0, 9);
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
                area[3] = Random.Range(0, 9);
                i++;
            }
            else
            {
                if (area[3] == area[0] || area[3] == area[1] || area[3]== area[2])
                {
                    area[3] = Random.Range(0, 9);
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
                area[4] = Random.Range(0, 9);
                i++;
            }
            else
            {
                if (area[4] == area[0] || area[4] == area[1] || area[4] == area[2]|| area[4] == area[3])
                {
                    area[4] = Random.Range(0, 9);
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
