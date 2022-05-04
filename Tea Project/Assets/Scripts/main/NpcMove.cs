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
    Quaternion startRotation;
    Quaternion endRotation;
    float rotationProgress = -1;
    public bool rotateStart = false;
    public float rotate = 0;
    public bool load = false;
    public string npc;
    public NpcMove xz;
    public Salo obj;
    void Start()
    {
        //npc = PlayerPrefs.GetString("AMOGUS", "def");
        //obj = JsonUtility.FromJson<Salo>(npc);
        //npc = PlayerPrefs.GetString("NPC_SAVE","def");
        //xz = JsonUtility.FromJson<NpcMove>(npc);
        //if (obj.weed) Load();  

        //    startRotation = transform.rotation;
        //    endRotation = Quaternion.Euler(0, -90, 0);
        //    rotationProgress = 0;
    }
    public void Load()
    { 
        npc = PlayerPrefs.GetString("NPC_SAVE", "def");
        xz = JsonUtility.FromJson<NpcMove>(npc);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dot")
        {
            
            StartCoroutine("startRot");
        }
    }

    IEnumerator startRot()
    {
        int i = 0;
        while (true)
        {
            if (i==1)
            {
                
                rotateStart = true;
                StopAllCoroutines();
            }
            i++;
            yield return new WaitForSeconds(.5f);
        }
    }

    void Update()
    {
        if (kak.reer == false)
        {
            step = MoveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, dot.position, step);
        }
        else if (kak.reer == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, back.position, step);
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        /*if (rotationProgress < 1 && rotationProgress >= 0)
        {
            rotationProgress += Time.deltaTime * 5;
            transform.rotation = Quaternion.Lerp(startRotation, endRotation, rotationProgress);
        }*/
        if (rotateStart && rotate > -90)
        {
            rotate -= 0.5f;
            transform.rotation = Quaternion.Euler(0,rotate,0);
        }
        else if(rotateStart && rotate == -90)
        {
            canvas.SetActive(true);
        }
    }
}   
