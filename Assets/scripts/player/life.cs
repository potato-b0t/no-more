using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public float lifepoint = 100;

    private void Update() {
        if (lifepoint <= 0){
            gameObject.GetComponentInChildren<Animator>().SetTrigger("died");
        }
    }
    public void GetHit(float hit){
        if(!gameObject.GetComponent<Player>().block){
            lifepoint -= hit;
        }
    }
}
