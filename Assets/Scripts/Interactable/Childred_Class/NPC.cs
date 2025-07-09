using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC : Interactable
{
    [SerializeField] private Animator animator;
    [SerializeField] private string[] dialogueLines;

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
        animator?.SetBool("inDialogue", true);
        Dialogue_System.Instance.StartDialogue(dialogueLines);
    }
}
