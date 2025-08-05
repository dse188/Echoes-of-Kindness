using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_StateMachine : MonoBehaviour
{
    [SerializeField] MonoBehaviour movementSource;
    private IMovementData m_player;

    private M_IState currentState;
    public M_Idle idleState = new M_Idle();
    public M_Walk walkState = new M_Walk();
    public M_Jump jumpState = new M_Jump();

    private void Start()
    {
        currentState = idleState;
        currentState.StateEnter(this);
    }

    private void Awake()
    {
        m_player = (IMovementData)movementSource;

        if (m_player == null)
        {
            Debug.LogError("Assigned Movement Source does not implement IMovementData.");
        }
    }

    private void Update()
    {
        currentState.StateUpdate(this);
    }

    public void M_SwitchState(M_IState newState)
    {
        //currentState.StateExit(this);

        currentState = newState;
        currentState.StateEnter(this);

    }

    public float Player_MovementValue()
    {
        return m_player.CurrentVelocity.magnitude;
        //return Mathf.Round(m_player.CurrentVelocity.magnitude);      // faster at transitioning from walkState to idleState since it quickly rounds down to zero when slowing down.
    }

    public bool Player_OnGround()
    {
        return m_player.OnGround;
    }
}
