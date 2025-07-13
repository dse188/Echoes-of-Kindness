using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_IdleState : NPC_BaseState
{
    public override void EnterState(NPC_StateManager npc)
    {
        throw new System.NotImplementedException();

        // Implementation of the idle animation
    }

    public override void UpdateState(NPC_StateManager npc)
    {
        throw new System.NotImplementedException();

        // If player starts to interact with this NPC, imediately transition to the next state.

        //npc.SwitchState(npc.[StateName]);
    }
}
