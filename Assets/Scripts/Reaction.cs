using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reaction : MonoBehaviour
{
    public Transform[] items;
    public GameObject item;
    public Text scoreText;
    private int score = 0;
    private bool playerConditioin = false;
    public Sprite closedChest;
    public Sprite openedChest;
    private void Start()
    {
        ItemSpawn();
        scoreText.text = System.Convert.ToString(score);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            Destroy(collision.gameObject);
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            playerConditioin = true;
        }
        if (collision.CompareTag("Chest") && playerConditioin)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            ItemSpawn();
            playerConditioin = false;
            score++;
            scoreText.text = System.Convert.ToString(score);
        }
        if (collision.CompareTag("Zone"))
        {
            collision.GetComponentInParent<SpriteRenderer>().sprite = openedChest;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Zone"))
        {
            collision.GetComponentInParent<SpriteRenderer>().sprite = closedChest;
        }
    }
    private void ItemSpawn()
    {
        int i = Random.Range(0, items.Length);
        Instantiate(item, new Vector3(items[i].position.x, items[i].position.y), Quaternion.identity);
    }
}
