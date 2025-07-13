using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_StateManager : MonoBehaviour
{
    NPC_BaseState currentState;
    public NPC_IdleState idleState = new NPC_IdleState();
    public NPC_WaitingState waitingState = new NPC_WaitingState();
    public NPC_HelpedState helpedState = new NPC_HelpedState();
    public NPC_TransformedState transformedState = new NPC_TransformedState();

    // Start is called before the first frame update
    void Start()
    {
        // starting state for the state machine
        currentState = idleState;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(NPC_BaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
