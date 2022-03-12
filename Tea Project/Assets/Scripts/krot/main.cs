using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{

    public Transform pointer;

    void Update()
    {
        Ray ray = new Ray(transform.position,transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.black);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            pointer.position = hit.point;

            if(hit.collider.gameObject.GetComponent<Selecta>())
            {
                hit.collider.gameObject.GetComponent<Selecta>().Select();
            }
        }
    }
}