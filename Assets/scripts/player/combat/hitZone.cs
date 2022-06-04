using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitZone : MonoBehaviour
{
    public float Damage;

    private void OnTriggerEnter(Collider collider) {
        switch (collider.tag){

            case "enemy":
                collider.GetComponent<life>().GetHit(Damage);
                gameObject.SetActive(false);
                break;
            default:
                gameObject.SetActive(false);
                break;
        }
        gameObject.SetActive(false);

    }
}
