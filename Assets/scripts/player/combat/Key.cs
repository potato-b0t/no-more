using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static Key instance;

    public bool canReceiveInput;
    public bool inputReceived;

    private void Awake()
    {
        instance = this;
    }

    public void key()
    {
        if (canReceiveInput)
        {
            inputReceived = true;
            canReceiveInput = false;
        }
        else
        {
            return;
        }
    }
    public void inputManager()
    {
        if (!canReceiveInput)
        {
            canReceiveInput = false;
        }
        else
        {
            canReceiveInput = true;
        }
    }
}
