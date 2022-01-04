using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    public GameObject bad;
    public GameObject good;
    void Start() 
    {
        StartCoroutine(grass());
    }
    IEnumerable grass()
    {
        Vector3 position;
        position.y = 6.5f;
        position.z = 9;
        position.x = 0;
        while (true)
        {
            int rd = Random.Range(0,10);
            //position.x = Random.Range(-3.49f,3.49f);
            /*if (rd > 7)
            {
                Instantiate(good, position, Quaternion.identity);    
            }
            else
            {*/
                
            //}
            Instantiate(bad, position, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
}
