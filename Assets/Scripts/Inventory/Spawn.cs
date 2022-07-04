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
        float dX = Random.Range(-1, 1f);
        float dY = Random.Range(-1.5f, 1.5f);
        Vector2 playerPos = new Vector2(player.position.x + dX, player.position.y + dY);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
