using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMove : MonoBehaviour
{
    public Vector3 saved_cord;
    public Quaternion saved_rotate;
    public string json_saved_cord;
    public string json_saved_rotate;
    public string json_load_cord;
    public string json_load_rotate;
    public Vector3 load_cord;
    public Quaternion load_rotate;
    public Transform me;
    public Transform dot;
    public Transform back;
    public float MoveSpeed = 1;
    public float step;
    public Boiling kak;
    public bool text;
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
        json_load_cord = PlayerPrefs.GetString("NPC_cord", "def");
        json_load_rotate = PlayerPrefs.GetString("NPC_rotate", "def");
        if ((json_load_cord != "def") & (json_load_rotate != "def"))
        {
            load_cord = JsonUtility.FromJson<Vector3>(json_load_cord);
            load_rotate = JsonUtility.FromJson<Quaternion>(json_load_rotate);
            transform.position = load_cord;
            transform.rotation = load_rotate;
        }
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
        //xz = JsonUtility.FromJson<NpcMove>(npc);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dot")
        {
            
            StartCoroutine("startRot");
        }
    }

    IEnumerator startRot()// kakogo ono tytt delaet&
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
        saving();
        json_saved_cord = JsonUtility.ToJson(saved_cord);
        json_saved_rotate = JsonUtility.ToJson(saved_rotate);
        PlayerPrefs.SetString("NPC_cord", json_saved_cord);
        PlayerPrefs.SetString("NPC_rotate", json_saved_rotate);
    }
    public void saving()
    {
        saved_cord = transform.position;
        saved_rotate = transform.rotation;
        
    }
}   
