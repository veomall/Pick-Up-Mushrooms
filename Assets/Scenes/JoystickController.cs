using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    public float speed;
    public Animator animator;
    private Vector3 MousePos;
    private Vector3 GlobalPos;
    public Joystick joystick;
    private void Start()
    {
        
    }
    private void Update()
    {
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
}
