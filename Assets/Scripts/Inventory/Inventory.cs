using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public bool full;
    private void Update()
    {
        full = true;
        foreach (var slot in isFull)
            full = full && slot;
        gameObject.GetComponent<Reaction>().canPick = !full;
    }
}
