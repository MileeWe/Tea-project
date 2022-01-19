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
        Ray ray = new Ray();
        ray.origin = transform.position;
        ray.direction = transform.position;
    }
}