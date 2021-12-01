using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject camera;
    public float rotationSpeed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (camera.transform.position.z < 2.5f && camera.transform.position.z > -0.5f)
        {
            camera.transform.position += new Vector3(0, 0, Input.GetAxis("Horizontal") * rotationSpeed);
        }
        else if(camera.transform.position.z > 2.5f)
        {
            camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, 2.5f);
        }
        else if (camera.transform.position.z < -0.5f)
        {
            camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, -1.5f);
        }
    }
}
