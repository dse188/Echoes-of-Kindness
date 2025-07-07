using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool isInteractable = true;

    public bool InitiateInteraction()
    {
        //if()

        return true;
    }

    public abstract void Interact();    // Does something when player interacts with an object

    public virtual void OnHover() 
    {
        // Show which object the player can interact with
        Debug.Log("gameObject is hovered. ");
    }
}
