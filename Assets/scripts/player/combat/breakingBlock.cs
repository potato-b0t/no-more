using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakingBlock : MonoBehaviour
{
    private void OnTriggerExit(Collider collider) {
        switch (collider.tag){
            case "enemy":
                collider.GetComponent<Block>().Blocker = false;
            break;

            default:
            break;
        }
    }
}
