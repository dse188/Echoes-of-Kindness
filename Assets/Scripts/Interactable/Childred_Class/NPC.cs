using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC : Interactable
{
    [SerializeField] private Animator animator;
    [SerializeField] private string[] dialogueLines;
    [SerializeField] private NPC_StateManager stateManager;
    [SerializeField] private Quest_SO assignedQuest;


    public override void Interact()
    {
        animator?.SetBool("inDialogue", true);
        Dialogue_System.Instance.StartDialogue(dialogueLines, OnDialogueComplete);
        stateManager.SwitchState(stateManager.waitingState);
    }

    private void OnDialogueComplete()
    {
        stateManager.SwitchState(stateManager.helpedState);
        animator?.SetTrigger("Helped");

        //Activate quest when dialogue ends
        if(assignedQuest != null)
        {
            QuestManager.Instance.ActivateQuest(assignedQuest);
        }
    }
}
