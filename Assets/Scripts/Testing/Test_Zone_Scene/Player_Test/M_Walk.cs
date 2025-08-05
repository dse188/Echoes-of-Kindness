using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_Walk : M_IState
{
    public void StateEnter(M_StateMachine player)
    {
        Debug.Log("I'm in Walk State!");
    }

    public void StateExit(M_StateMachine player)
    {
        
    }

    public void StateUpdate(M_StateMachine player)
    {
        if (player.Player_MovementValue() <= 0.01)
        {
            player.M_SwitchState(player.idleState);
        }
        else if (!player.Player_OnGround())
        {
            player.M_SwitchState(player.jumpState);
        }
    }

}
