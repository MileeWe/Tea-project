using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerRay : MonoBehaviour
{
    public Transform Pointer;
    public stage sas;
    void Start()
    {
    }
    

    void Update()
    {
        Ray ray = new Ray();
        ray.origin = transform.position;
        ray.direction = transform.forward;
        Debug.DrawRay(transform.position, transform.forward * 10f, Color.yellow);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) 
        {
            Pointer.position = hit.point;
            if (hit.collider.gameObject.GetComponent<Selectable>() && Input.GetKey(KeyCode.Mouse0))
            {
                //hit.collider.gameObject.GetComponent<Selectable>().Select();
                sas.stageNumber = 1;
            }
            if (hit.collider.gameObject.GetComponent<onMouseEnter>() && Input.GetKey(KeyCode.Mouse0))
            {
                // hit.collider.gameObject.GetComponent<onMouseEnter>().Select();
                sas.stageNumber = 2;
            }
        }
       
    }
   

}