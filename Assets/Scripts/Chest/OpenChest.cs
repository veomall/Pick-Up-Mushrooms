using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    private Movement movement;
    private void Start()
    {
        movement = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        print(0);
        movement.GlobalPos = collision.transform.position;
        
    }
    private void OnMouseDown()
    {
        print(1);
        movement.GlobalPos = gameObject.transform.position;
    }
}
