using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject player;
    public GameObject InteractbleObject;
    public KeyBinds keybinds;
    public float distance;
   

    private void Update()
    {
        // tells pplayer to interact with items
        if(keybinds.GetKeyDown("Interact"))
        {
            isInteractable();
        }
    }
    // checks if player is close enough to interact
    public void isInteractable()
    {
        distance = (InteractbleObject.transform.position - player.transform.position).magnitude;

        if (distance < 5f)
        {
            Interact();
        }
        else
        {
            Debug.Log("nothing to interact with");
        }


    }

    // place holder gets overided in other scripts
    public virtual void Interact()
    {
        Debug.Log("interact");
    }
}
