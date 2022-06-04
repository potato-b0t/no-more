using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject camPos;
    public float speedCam;
    private void Awake() {
        camPos.transform.position =gameObject.transform.position;
    }
    void Update()
    {
        if (camPos.GetComponentInParent<CamSizeAndPosition>().CamFollowing)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, camPos.transform.position, speedCam);

        }
    }
}
