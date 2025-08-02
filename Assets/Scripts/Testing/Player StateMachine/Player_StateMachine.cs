using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_StateMachine : MonoBehaviour
{
    private State currentState;
    public Player_IdleState player_IdleState = new Player_IdleState();
    public Player_WalkState player_WalkState = new Player_WalkState();
    public Player_DialogueState player_DialogueState = new Player_DialogueState();

    private void Start()
    {
        currentState = player_IdleState;
        currentState.EnterState(this);  // Remember, EnterState(Player_StateMachine player) takes in an object from ----THIS---- Player_StateMachine class.
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(State newState)
    {
        currentState = newState;
        currentState.EnterState(this);
    }

    

}
