using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_WaitingState : NPC_BaseState
{
    public override void EnterState(NPC_StateManager npc)
    {
        //throw new System.NotImplementedException();
        Debug.Log("NPC entered Waiting State!");
    }

    public override void UpdateState(NPC_StateManager npc)
    {
        //throw new System.NotImplementedException();
    }
}
