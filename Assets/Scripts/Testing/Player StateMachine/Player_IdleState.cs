using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_IdleState : State
{

    public override void EnterState(Player_StateMachine player)
    {
        Debug.Log("Player in idle state");
    }

    public override void UpdateState(Player_StateMachine player)
    {
        
    }

    /*public Player_IdleState(State state)
    {
        currentVelocity = state.CurrentVelocity;
        playerState = state.PlayerState;

        idleVelocity = Vector3.zero;
        walkVelocity = Vector3.zero;
    }

    public override void PlayerIdle(Vector3 pVelocity)
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
