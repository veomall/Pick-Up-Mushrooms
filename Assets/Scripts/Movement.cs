using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D player;
    public Joystick joystick;
    public Animator animator;
    private Vector2 moveVelocity;
    private Vector3 MousePos;
    private Vector3 GlobalPos;
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            MousePos = Input.mousePosition;
            GlobalPos = Camera.main.ScreenToWorldPoint(MousePos);
            print(GlobalPos);
        }
        player.MovePosition(GlobalPos);
        Vector2 moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
        moveVelocity = moveInput.normalized * speed;
        float H = joystick.Horizontal;
        float V = joystick.Vertical;
        if (H > 0 && V > 0)
        {
            if (H > V)
            {
                animator.SetBool("right", true);
                animator.SetBool("left", false);
                animator.SetBool("up", false);
                animator.SetBool("down", false);
            }
            else
            {
                animator.SetBool("right", false);
                animator.SetBool("left", false);
                animator.SetBool("up", true);
                animator.SetBool("down", false);
            }
        }
        else if (H > 0 && V < 0)
        {
            V = System.Math.Abs(V);
            if (H > V)
            {
                animator.SetBool("right", true);
                animator.SetBool("left", false);
                animator.SetBool("up", false);
                animator.SetBool("down", false);
            }
            else
            {
                animator.SetBool("right", false);
                animator.SetBool("left", false);
                animator.SetBool("up", false);
                animator.SetBool("down", true);
            }
        }
        if (H < 0 && V < 0)
        {
            H = System.Math.Abs(H);
            V = System.Math.Abs(V);
            if (H > V)
            {
                animator.SetBool("right", false);
                animator.SetBool("left", true);
                animator.SetBool("up", false);
                animator.SetBool("down", false);
            }
            else
            {
                animator.SetBool("right", false);
                animator.SetBool("left", false);
                animator.SetBool("up", false);
                animator.SetBool("down", true);
            }
        }
        if (H < 0 && V > 0)
        {
            H = System.Math.Abs(H);
            V = System.Math.Abs(V);
            if (H > V)
            {
                animator.SetBool("right", false);
                animator.SetBool("left", true);
                animator.SetBool("up", false);
                animator.SetBool("down", false);
            }
            else
            {
                animator.SetBool("right", false);
                animator.SetBool("left", false);
                animator.SetBool("up", true);
                animator.SetBool("down", false);
            }
        }
        else if (H == 0 && V == 0)
        {
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
        }
    }
    private void FixedUpdate()
    {
        player.MovePosition(player.position + moveVelocity * Time.fixedDeltaTime);
    }
}