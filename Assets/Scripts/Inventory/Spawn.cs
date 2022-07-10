using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void SpawnDroppedItem()
    {
        float dX = Random.Range(0.7f, 1.2f);
        float dY = Random.Range(1.2f, 1.6f);
        Vector2 playerPos = new Vector2(player.position.x + dX, player.position.y + dY);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
