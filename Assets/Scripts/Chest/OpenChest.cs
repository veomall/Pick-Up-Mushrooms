using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    private bool chestIsTarget = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (chestIsTarget)
        {
            print(0);
        }
    }
    private void OnMouseDown()
    {
        print(0);
        chestIsTarget = true;
    }
}
