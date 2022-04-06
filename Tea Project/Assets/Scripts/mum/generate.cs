using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    public GameObject bad;
    public GameObject good;
    public GameObject badgood;
    public GameObject legendary;
    public GameObject orange;
    public GameObject beb;
    void Start() 
    {
        StartCoroutine(grass());
    }
    IEnumerator grass()
    {
        Vector3 position;
        position.y = 16.5f;
        position.z = 9;
        position.x = 0;
        while (true)
        {
            int rd = Random.Range(1,17);
            position.x = Random.Range(-3.49f,3.49f);
            switch (rd)
            {
                case 16:
                    Instantiate(legendary, position, Quaternion.identity);
                    break;
                case 15: case 14: case 13:
                    Instantiate(beb, position, Quaternion.identity);
                    break;
                case 12: case 11: case 10:
                    Instantiate(orange, position, Quaternion.identity);
                    break;
                case 9: case 8: case 7:
                    Instantiate(good, position, Quaternion.identity);
                    break;
                case 6: case 5: case 4:
                    Instantiate(badgood, position, Quaternion.identity);
                    break;
                case 3: case 2: case 1:
                    Instantiate(bad, position, Quaternion.identity);
                    break;
            }
            yield return new WaitForSeconds(0.5F);
        }
    }
}