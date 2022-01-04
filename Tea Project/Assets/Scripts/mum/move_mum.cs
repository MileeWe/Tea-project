using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_mum : MonoBehaviour
{
    public GameObject charter;
    public string goodTag;
    public string badTag;
    public int score = 0;
    public Text scoreText;  
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == goodTag)
        {
            score += 1;
        }
        if (other.gameObject.tag == badTag)
        {
            score -= 1;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = "Score: " + score;
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -3.49f)
            {
                transform.position += new Vector3(-7*Time.deltaTime,0,0);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 3.49f)
            {
                transform.position += new Vector3(7*Time.deltaTime,0,0);
            }
        }
    }
}