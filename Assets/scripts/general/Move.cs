using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    public float speed;

    private CharacterController controller;
    private Animator animMove;

    private void Start() {
        controller = GetComponent<CharacterController>();
        animMove = GetComponent<Player>().anim;
    }
    public void move(Vector3 direction, float x){
        controller.Move(direction * speed * Time.deltaTime);
        animMove.SetTrigger("moving");
        animMove.SetFloat("speedAnim", x);
    }
    public void Idle(Vector3 direction){
        controller.Move(direction * speed * Time.deltaTime);
        animMove.SetBool("moving",  false);
    }
}
