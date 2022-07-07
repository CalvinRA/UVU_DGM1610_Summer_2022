using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{

    // Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider collision)
    {
        PlayerManager manager = collision.GetComponent<PlayerManager>();

        if(manager)
        {
            bool pickedUp = manager.PickUpItem(gameObject);
            if(pickedUp)
            {
                Destroy(gameObject);
            }
        }

    }
}
