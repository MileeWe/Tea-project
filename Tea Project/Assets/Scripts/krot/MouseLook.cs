using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public GameObject go;
    public float sensitivity = 1F;
    public Camera goCamera;
    private Vector3 MousePos;
    private float MyAngle = 0F;

    void Start()
    {
        // Инициализируем кординаты мышки и ищем главную камеру
        //goCamera = camera;
        Cursor.lockState = CursorLockMode.Locked;
        go = goCamera.transform.parent.gameObject;
    }

    void Update()
    {
        MousePos = Input.mousePosition;
        transform.Rotate(10,0,0);
    }

    void FixedUpdate()
    {
        //if (Input.GetMouseButton(1))
        //{
            MyAngle = 0;
            // расчитываем угол, как:
            // разница между позицией мышки и центром экрана, делённая на размер экрана
            //  (чем дальше от центра экрана тем сильнее поворот)
            // и умножаем угол на чуствительность из параметров
            MyAngle = sensitivity * ((MousePos.x - (Screen.width / 2)) / Screen.width);
            goCamera.transform.RotateAround(go.transform.position, goCamera.transform.up, MyAngle);
            MyAngle = sensitivity * ((MousePos.y - (Screen.height / 2)) / Screen.height);
            goCamera.transform.RotateAround(go.transform.position, goCamera.transform.right, -MyAngle);
        //}
    }
}