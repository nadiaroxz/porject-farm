using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlotsUI : MonoBehaviour
{
    public Image collectableIcon;
    public TextMeshProUGUI quantityText;

    public void SetCollectable(Inventory.Slot slot)
    {
        if(slot != null)
        {
            collectableIcon.sprite = slot.collectableIcon;
            collectableIcon.color =  new Color(1, 1, 1, 1);
            quantityText.text = slot.inventoryCount.ToString();
        }
    }

    public void SetEmpty()
    {
        // makes image invisible
        collectableIcon.sprite = null;
        collectableIcon.color =  new Color(1, 1, 1, 0);
        quantityText.text = string.Empty;
    }
}
