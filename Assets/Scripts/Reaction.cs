using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reaction : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public Sprite closedChest;
    public Sprite openedChest;
    private void Start()
    {
        scoreText.text = System.Convert.ToString(score);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
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
}
