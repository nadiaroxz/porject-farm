using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public CollectableType collectableType;
    public Sprite collectableIcon;

    private void OnTriggerEnter2D(Collider2D collisions)
    {
            Player player = collisions.GetComponent<Player>();

            // if player collides add berry to player
            if(player)
            {
                player.inventory.Add(this);
                // delete seed from world
                Destroy(this.gameObject);
            }
    }
}

public enum CollectableType
{
    Not_Set,  //0
    Berry_Seed //1
}