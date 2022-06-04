using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadEnergy : MonoBehaviour
{
    private Animator animator;
    public float speedLoad;

    public bool loading;

    private void Start() {
        animator = GetComponent<Player>().anim;
    }

    private void Update() {
        if(gameObject.GetComponent<Player>().Energy >= 100){
            gameObject.GetComponent<Player>().Energy = 100;
        }
    }
    public void LoadEnergy(){
        if (gameObject.GetComponent<Player>().Energy < 100){
            animator.SetBool("loading", true);
            animator.SetBool("moving", false);
            gameObject.GetComponent<moveKeyboard>().CanMove = false;
            gameObject.GetComponent<Player>().Energy += speedLoad * Time.deltaTime;

            loading = true;
        }
        else if (gameObject.GetComponent<Player>().Energy >= 100){
            animator.SetBool("full load", true);
            gameObject.GetComponent<moveKeyboard>().CanMove = false;
            gameObject.GetComponent<Player>().Energy = 100;

        }
    }
    public void NotLoading(){
        animator.SetBool("loading", false);
        animator.SetBool("full load", false);
        gameObject.GetComponent<moveKeyboard>().CanMove = true;

    }
}
