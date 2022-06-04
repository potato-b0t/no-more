using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lookLife : MonoBehaviour
{
    public life life;
    void Update()
    {
        gameObject.GetComponent<Text>().text = (life.lifepoint).ToString();
    }
}
