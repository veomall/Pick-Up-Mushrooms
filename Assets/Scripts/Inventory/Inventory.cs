using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public bool full;
    public GameObject inventory;
    private bool inventoryOn;
    public Sprite openedInventory;
    public Sprite closedInventory;
    public GameObject inventoryCollider;
    public GameObject chest;
    private void Update()
    {
        full = true;
        foreach (var slot in isFull)
            full = full && slot;
        gameObject.GetComponent<Reaction>().canPick = !full;
    }
    private void Start()
    {
        inventoryOn = false;
    }
    public void Chest()
    {
        if (inventoryOn)
        {
            inventoryOn = false;
            inventory.SetActive(false);
            chest.GetComponent<Image>().sprite = closedInventory;
            inventoryCollider.SetActive(false);
        }
        else if (!inventoryOn)
        {
            inventoryOn = true;
            inventory.SetActive(true);
            chest.GetComponent<Image>().sprite = openedInventory;
            inventoryCollider.SetActive(true);
        }
    }
}
