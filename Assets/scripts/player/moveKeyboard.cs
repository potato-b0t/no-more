using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveKeyboard : MonoBehaviour
{
    public plataform scripter;
    public Joystick joystick;
    private float x;
    private float y;
    private Vector3 moveDirection;
    private Move move;
    private Block Block;
    private CombatManager hitManager;
    public bool CanMove;

    private void Start()
    {
        move = GetComponent<Move>();
        Block = GetComponent<Block>();
        hitManager = GetComponent<CombatManager>();
        CanMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        moveController();
        loadEnergy();
        Blocker();


        //attack
        if (Input.GetMouseButton(0) && !scripter.android)
        {
            if (!gameObject.GetComponent<Player>().block && !gameObject.GetComponent<loadEnergy>().loading)
            {
                hitManager.Attack();
            }
            else if (gameObject.GetComponent<Player>().block && !gameObject.GetComponent<loadEnergy>().loading)
            {
                gameObject.GetComponent<Key>().key();
            }
        }

        if(Input.GetMouseButton(1) && !scripter.android){

        }

    }

    void moveController()
    {
        if (CanMove)
        {
            x = joystick.Horizontal + Input.GetAxis("Horizontal");

            moveDirection = transform.forward * x * -1;

            if (x != 0)
            {
                move.move(moveDirection, x);
            }
            else
            {
                move.Idle(moveDirection);
            }
        }

    }
    void loadEnergy()
    {
        y = joystick.Vertical + Input.GetAxis("Vertical");
        if (y >= 0.4f)
        {
            gameObject.GetComponent<loadEnergy>().LoadEnergy();
        }
        else if (y < 0.4f)
        {
            gameObject.GetComponent<loadEnergy>().NotLoading();
        }
    }

    void Blocker()
    {
        y = joystick.Vertical + Input.GetAxis("Vertical");
        if (y <= -0.4f)
        {
            CanMove = false;
            Block.blocking();
        }
        else if (y > -0.4f)
        {
            CanMove = true;
            Block.NotBlocking();
        }
    }
}
