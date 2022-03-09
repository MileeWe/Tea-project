using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    void Update()
    {
        Ray ray = new Ray(transform.position,transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.black);

        Physics.Raycast(ray);

        if (Physics.Raycast(ray))
        {
            Debug.Log("Hit smth");
        }
    }
}