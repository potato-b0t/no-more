using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator anim;
    public bool block;
    public float Energy;

    public bool loading;

    public static Player instance;
    private void Awake() {
        instance = this;
    }
}
