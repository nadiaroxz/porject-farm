using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
// ^ makes it so we can see inv in unity inspector
public class Inventory
{
    [System.Serializable]
    //  ^ so we can see slots
    public class Slot
    {
        public CollectableType collectableType;
        public int inventoryCount;
        public int maxInventorySpace;
        public Sprite collectableIcon;
        public bool IsFreeSlot => inventoryCount <= maxInventorySpace ? true : false;

        public Slot()
        {
            // config
            collectableType = CollectableType.Not_Set;
            inventoryCount = 0;
            maxInventorySpace = 22;
        }

        public void AddCollectable(Collectable collectable)
        {
            this.collectableType = collectable.collectableType;
            this.collectableIcon = collectable.collectableIcon;
            inventoryCount++;
        }

    }

    public List<Slot> slots = new List<Slot>();

    public Inventory (int slotsCount)
    {
            // creates slots for inv
            for(int i = 0; i < slotsCount; i++)
            {
                Slot slot = new Slot();
                slots.Add(slot);
            }
    }


    public void Add(Collectable collectable)
    {
        foreach (Slot slot in slots)
        {
            // check if slot is free & if we have item of that type
            if(slot.collectableType == collectable.collectableType  && slot.IsFreeSlot)
            {
                 // add item
                slot.AddCollectable(collectable);
                return;
            }

            // add item of new type
            if(slot.collectableType == CollectableType.Not_Set )
            {
                slot.AddCollectable(collectable);
                return;
            }
        }
    }
}
