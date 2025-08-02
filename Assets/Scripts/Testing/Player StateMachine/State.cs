using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public abstract void EnterState(Player_StateMachine player);
    public abstract void UpdateState(Player_StateMachine player);

    /*protected PlayerState playerState;

    protected Vector3 currentVelocity;
    protected Vector3 idleVelocity;
    protected Vector3 walkVelocity;

    public PlayerState PlayerState
    {
        get { return playerState; }
        set { playerState = value; }
    }

    public Vector3 CurrentVelocity
    {
        get { return currentVelocity; }
        set { currentVelocity = value; }
    }

    //Our player states
    public abstract void PlayerIdle(Vector3 pVelocity);
    public abstract void PlayerWalk(Vector3 pVelocity);
    public abstract void PlayerInDialogue();*/
}
