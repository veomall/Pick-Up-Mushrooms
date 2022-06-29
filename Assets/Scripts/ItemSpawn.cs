using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public Sprite[] items;
    private void Start()
    {
        int r = Random.Range(0, 2);
        if (r == 0)
        {
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = items[0];
        }
    }
}
