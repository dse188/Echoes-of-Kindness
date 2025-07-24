using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_HelpedState : NPC_BaseState
{
    public override void EnterState(NPC_StateManager npc)
    {
        Debug.Log("NPC entered Helped State!");
    }

    public override void UpdateState(NPC_StateManager npc)
    {
        
    }
}
