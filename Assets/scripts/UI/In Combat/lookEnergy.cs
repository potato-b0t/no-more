using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lookEnergy : MonoBehaviour
{
    public Player player;
    void Update()
    {
        gameObject.GetComponent<Text>().text = (Mathf.Floor(player.Energy)).ToString();
    }
}
