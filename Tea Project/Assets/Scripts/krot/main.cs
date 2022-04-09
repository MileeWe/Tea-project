using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{

    public Camera camera;

    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //pointer.position = hit.point;

            Selecta selecta = hit.collider.gameObject.GetComponent<Selecta>();
            if (selecta && Input.GetKeyDown(KeyCode.Mouse0))
            {
                selecta.Select();
            }
        }
    }
}