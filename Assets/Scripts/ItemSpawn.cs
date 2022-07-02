using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject[] items;
    public bool isFull = false;
    public bool canPut = true;
    private float updateTime;
    private float localTime;
    private void Start()
    {
        int r = Random.Range(0, 2);
        if (r == 0)
        {
            int i = Random.Range(0, items.Length);
            Instantiate(items[i], transform.position, Quaternion.identity);
            isFull = true;
        }
        updateTime = Random.Range(10, 25);
        localTime = updateTime;
    }
    private void Update()
    {
        if (!isFull)
        {
            localTime -= Time.deltaTime;
        }
        if (localTime < 0)
        {
            int i = Random.Range(0, items.Length);
            Instantiate(items[i], transform.position, Quaternion.identity);
            isFull = true;
            localTime = updateTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && collision.GetComponent<Reaction>().canPick)
        {
            isFull = false;
        }
    }
}
