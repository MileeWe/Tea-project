using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_mum : MonoBehaviour
{
    public string goodTag;
    public string badTag;
    public string badgoodTag;
    public string legendaryTag;
    public orders very_sus;
    public int score = 0;
    public Text scoreText;
    public generate stop;
    void Start()
    {
        
    }
    /*void Update()
    {
        var FBI_CONTROL = orders.marijuana;
        Debug.Log(FBI_CONTROL);
    }*/

    public void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other.gameObject.tag);
        var FBI_CONTROL = orders.marijuana;
        Debug.Log(FBI_CONTROL);
        if (other.gameObject.tag == legendaryTag)
        {
            score += 3;
            Destroy(other.gameObject);
        }
        switch (FBI_CONTROL)
        {
            case "green":
                switch (other.gameObject.tag)
                {
                    case "good":
                        score += 1;
                        Destroy(other.gameObject);
                        break;
                    case "badgood":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "bad":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "orange":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "beb":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                }
                break;
            case "yellow":
                switch (other.gameObject.tag)
                {
                    case "good":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "badgood":
                        score += 1;
                        Destroy(other.gameObject);
                        break;
                    case "bad":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "orange":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "beb":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                }
                break;
            case "red":
                switch (other.gameObject.tag)
                {
                    case "good":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "badgood":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "bad":
                        score += 1;
                        Destroy(other.gameObject);
                        break;
                    case "orange":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "beb":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                }
                break;
            case "orange":
                switch (other.gameObject.tag)
                {
                    case "good":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "badgood":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "bad":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "orange":
                        score += 1;
                        Destroy(other.gameObject);
                        break;
                    case "beb":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                }
                break;
            case "beb":
                switch (other.gameObject.tag)
                {
                    case "good":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "badgood":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "bad":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "orange":
                        score -= 1;
                        Destroy(other.gameObject);
                        break;
                    case "beb":
                        score += 1;
                        Destroy(other.gameObject);
                        break;
                }
                break;
        }
        
    }
    // Update is called once per frame //wat?
    void FixedUpdate()
    {
        if (score >= 5) u_win_bitch();
        else if (score <= -10) u_lose_bitch();
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
        void u_lose_bitch()
        {
        scoreText.text = "you lose";
        stop.gen = false;
        }
        void u_win_bitch()
        {
        scoreText.text = "you win";
        stop.gen = false;
        }
    }
    
}