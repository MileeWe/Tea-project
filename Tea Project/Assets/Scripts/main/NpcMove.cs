using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMove : MonoBehaviour
{
    public Transform dot;
    public Transform back;
    public float MoveSpeed = 1;
    public float step;
    public Boiling kak;
    public bool text;
    public float TimeLeft;
    public GameObject canvas;
    void Start()
    {
        //back.position = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dot")
        {
            Debug.Log("ggg");
            canvas.SetActive(true);
        }
    }

    void Update()
    {
        if (kak.reer == false)
        {
            step = MoveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, dot.position, step);
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if (kak.reer == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, back.position, step);
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        else Debug.Log("lox x2");
        /*TimeLeft = 0.02;
        TimeLeft -= Time.deltaTime;
        if (TimeLeft < 0)
        {
            text = true;
        }*/
    }
    public void go_back_i_want_to_be_monkey()
    {
        Debug.Log("sam kek");
        transform.position = Vector3.MoveTowards(transform.position, back.position, step);
        transform.rotation = Quaternion.Euler(0, -180, 0);
    }
}
