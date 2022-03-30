using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    public GameObject bad;
    public GameObject good;
    public GameObject badgood;
    public GameObject legendary;
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
            int rd = Random.Range(0,11);
            position.x = Random.Range(-3.49f,3.49f);
            if (rd == 10)
            {
                Instantiate(legendary, position, Quaternion.identity);
            }
            if (rd <= 3)
            {
                Instantiate(good, position, Quaternion.identity);    
            }
            else if((rd > 3) & (rd < 7))
            {
                Instantiate(badgood, position, Quaternion.identity);
            }
            else if ((rd >= 7) & (rd < 10))
            {
                Instantiate(bad, position, Quaternion.identity);
            }
            yield return new WaitForSeconds(0.6F);
        }
    }
}