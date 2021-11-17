using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boiling : MonoBehaviour
{
    public Slider boil;
    public bool target = false;
    public float maxBoilInter = 200;
    public int rd;
    public Slider boilTwo;
    public Transform boilTrans;
    public GameObject prafab;
    public GameObject canvas;
    void Start()
    {
        Vector3 position = boilTrans.transform.position;
        boil.maxValue = 200;
        boil.value = 0;
        rd = Random.Range(20, 180);
        boilTwo.value = rd;
        position = new Vector3(position.x + rd-0.5f*boilTrans.gameObject.GetComponent<RectTransform>().rect.width, position.y, position.z);
        Instantiate(prafab, position, Quaternion.identity, canvas.transform);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            target = true;
        }
        if (boil.value < maxBoilInter && !target)
        {
            boil.value += 0.05f;
        }
        if (!target && boil.value <= (rd+10)&& boil.value >=(rd-10))
        {
            Debug.Log("Good boy");
        }
    }
}