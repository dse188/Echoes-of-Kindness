using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_WalkState : State
{
    public override void EnterState(Player_StateMachine player)
    {
        Debug.Log("Player in walk state");
    }

    public override void UpdateState(Player_StateMachine player)
    {
        
    }

    /*public override void PlayerIdle(Vector3 pVelocity)
    {
        throw new System.NotImplementedException();
    }
    public override void PlayerWalk(Vector3 pVelocity)
    {
        throw new System.NotImplementedException();
    }

    public override void PlayerInDialogue()
    {
        throw new System.NotImplementedException();
    }*/

}
