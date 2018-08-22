using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Idle,
    Left,
    Right
}


[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour {

    public PlayerState PS;
    public Animator animator;

    public float moveSpeed = 5;
    PlayerController controller;

    void Start()
    {
        controller = GetComponent<PlayerController>();
    }

    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * moveSpeed;
        controller.Move(moveVelocity);
        if (Input.GetKeyDown(KeyCode.A))
        {

        }
    }

    void Left()
    {
        PS = PlayerState.Left;
        animator.SetTrigger("Left");
    }
    void Right()
    {
        PS = PlayerState.Right;
        animator.SetTrigger("Right");
    }

}
