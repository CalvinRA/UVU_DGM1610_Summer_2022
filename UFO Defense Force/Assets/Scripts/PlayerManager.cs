using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int inventory;

    public bool PickUpItem(GameObject obj)
    {
        switch(obj.tag)
        {
            case "PickUp":
                inventory++;
                Debug.Log(inventory);
                return true;
            default:
                return false;
        }
        
    }
}
