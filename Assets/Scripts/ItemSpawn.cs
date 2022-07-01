using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject[] items;
    private bool isFull = false;
    private void Start()
    {
        int r = Random.Range(0, 2);
        if (r == 0)
        {
            int i = Random.Range(0, items.Length);
            Instantiate(items[i], transform.position, Quaternion.identity);
            isFull = true;
        }
    }
}
