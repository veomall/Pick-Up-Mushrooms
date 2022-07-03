using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnBack : MonoBehaviour
{
    private Movement move;
    private void Start()
    {
        move = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
    }
    private void OnMouseDown()
    {
        move.isBack = true;
    }
}
