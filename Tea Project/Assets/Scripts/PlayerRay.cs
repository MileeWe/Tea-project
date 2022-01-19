using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerRay : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

        RaycastHit hit;
        Ray ray = new Ray();
        ray.origin = transform.position;
        ray.direction = transform.position;
        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
        }
    }
}