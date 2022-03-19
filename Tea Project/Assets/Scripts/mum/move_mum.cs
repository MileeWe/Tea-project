using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_mum : MonoBehaviour
{
    public string goodTag;
    public string badTag;
    public string badgoodTag;
    public orders very_sus;
    public string ddd;
    public int score = 0;
    public Text scoreText;
    // & (very_sus == "yellow")
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other) 
    {
        ddd = very_sus.marijuana;
        Debug.Log(ddd);
        if ((other.gameObject.tag == goodTag))
        {
            score += 1;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == badgoodTag)
        {
            score += 2;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == badTag)
        {
            score -= 1;
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame //wat?
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