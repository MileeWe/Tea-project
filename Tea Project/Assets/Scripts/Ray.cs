using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour
{
    Ray RayOrigin;
    RaycastHit HitInfo;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            RayOrigin = Camera.main.ViewportPointToRay(new Vector3(0, 0, 0));
            Transform cameraTransform = Camera.main.transform;
            if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out HitInfo, 100.0f))
                Debug.DrawRay(cameraTransform.position, cameraTransform.forward * 100.0f, Color.yellow);
            {
                Debug.DrawRay(RayOrigin.direction, HitInfo.point, Color.yellow);
            }
        }

    }
}
