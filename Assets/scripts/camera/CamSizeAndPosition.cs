using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSizeAndPosition : MonoBehaviour
{
    public bool CamFollowing;
    public Transform player, enemy;
    public Camera cam;
    public float angular;

    private float IDistance;
    public float distance;

    private void Start() {
        float playerNN = player.position.x * -1;

        IDistance = (playerNN + enemy.position.x) * 2f;    
    }

    // Update is called once per frame
    void Update()
    {
        //center cam on zone
        gameObject.transform.position = (player.position + enemy.position) / 2;

        //size camera
        sizeCameraCondicion();
    }

    void sizeCameraCondicion()
    {
        if (enemy.position.x > player.position.x)
        {
            distance = enemy.position.x - player.position.x;

            CameraSize();

        }
        if (enemy.position.x < player.position.x)
        {
            distance = enemy.position.x - player.position.x;
 
            CameraSize();

        }
    }
    void CameraSize(){
        if (distance > IDistance)
            {
                cam.GetComponentInChildren<Camera>().orthographicSize = (angular * distance) + 5;
            }
            else if(distance <= IDistance){
                cam.GetComponentInChildren<Camera>().orthographicSize = (angular * IDistance) + 5;
            }
    }
}
