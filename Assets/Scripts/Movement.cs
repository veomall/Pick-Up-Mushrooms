using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Animator animator;
    private Vector3 MousePos;
    public Vector3 GlobalPos;
    public GameObject pointer;
    public bool isBack = false;
    private void Start()
    {
        GlobalPos = transform.position;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isBack)
        {
            MousePos = Input.mousePosition;
            GlobalPos = Camera.main.ScreenToWorldPoint(MousePos);
            pointer.transform.position = new Vector3(GlobalPos.x, GlobalPos.y);
            isBack = false;
        }
        gameObject.transform.position = Vector2.MoveTowards(transform.position, GlobalPos, speed * Time.deltaTime);
        float H = GlobalPos.x - transform.position.x;
        float V = GlobalPos.y - transform.position.y;
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