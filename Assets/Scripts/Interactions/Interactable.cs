using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject player;
    public GameObject InteractbleObject;
    public Keybinds keybinds;
    public float distance;
   

    private void Update()
    {
        if(Inputmanger.inputmanger.KeyDown("Interact"))
        {
            isInteractable();
        }
    }
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

    
    public virtual void Interact()
    {
        Debug.Log("interact");

    }
}
