using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject scripter;

    private Animator animBlock;

    private void Start() {
        animBlock = GetComponent<Player>().anim;
    }

    public bool Blocker;
    private void Update() {
        if(Blocker){
            blocking();
        } else {
            NotBlocking();
        }
    }

    public void blocking(){
        scripter.GetComponent<moveBool>().canMove = false;
        scripter.GetComponent<BlockBool>().blocking = true;
        
        gameObject.GetComponent<Player>().block = scripter.GetComponent<BlockBool>().blocking;

        animBlock.SetBool("block", true);
        animBlock.SetBool("moving", false);

    }
    public void NotBlocking(){
        scripter.GetComponent<moveBool>().canMove = true;
        scripter.GetComponent<BlockBool>().blocking = false;
        
        gameObject.GetComponent<Player>().block = scripter.GetComponent<BlockBool>().blocking;

        animBlock.SetBool("block", false);

    }
}
