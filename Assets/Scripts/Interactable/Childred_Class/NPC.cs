using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        //Debug.Log("Yay you interacted with: " + this.gameObject.name);
        Debug.Log("My wallet is missing! What am I gonna do?!");
    }

}
