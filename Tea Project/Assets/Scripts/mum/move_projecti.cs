using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_projecti : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,0,10*Time.deltaTime);
        if (transform.position.z > 25)
        {
            Destroy(gameObject);
        }
    }
}
