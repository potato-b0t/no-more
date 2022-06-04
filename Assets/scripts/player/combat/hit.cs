using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public float damage, radiusHit;
    public GameObject LHand, RHand;

    //left hand
    public void hitLeft(){
        Hit(LHand);
    }

    //right hand
    public void hitRight(){
        Hit(RHand);
    }

    //give damage
    private void Hit(GameObject position){
        position.SetActive(true);
    }
}
