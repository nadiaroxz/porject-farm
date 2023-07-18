using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    public Player player;
    public List<SlotsUI> slots = new List<SlotsUI>();
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleInventory();
        }
    }

    public void ToggleInventory()
    {
        // if inventory panel is off, turn on
        //else turn it off
        if(!inventoryPanel.activeSelf)
        {
            inventoryPanel.SetActive(true);
            Refresh();
        }
        else
        {
            inventoryPanel.SetActive(false);
        }
    }

    void Refresh()
    {
        if(slots.Count == player.inventory.slots.Count)
        {
            for(int i = 0; i < slots.Count; i++)
            {
                if(player.inventory.slots[i].collectableType != CollectableType.Not_Set)
                {
                    slots[i].SetCollectable(player.inventory.slots[i]);
                }
                else
                {
                    slots[i].SetEmpty();
                }
            }
        }
    }
}
