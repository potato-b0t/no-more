using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataform : MonoBehaviour
{
    public GameObject AndroidUI;
    public bool android;

    private void Update() {
        if (android){
            Android();
        }
        else if (!android)
        {
            NotAndroid();
        }
    }
    void Android(){
        AndroidUI.SetActive(true);
    }
    void NotAndroid(){
        AndroidUI.SetActive(false);
    }
}
