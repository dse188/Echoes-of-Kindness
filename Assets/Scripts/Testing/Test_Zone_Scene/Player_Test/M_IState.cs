using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface M_IState
{
    public void StateEnter(M_StateMachine player); // code that runs when we first enter the state

    public void StateUpdate(M_StateMachine player); // per-frame logic (typically used by Update()), include condition to transition to a new state

    public void StateExit(M_StateMachine player); // code that runs when we exit the state
}
