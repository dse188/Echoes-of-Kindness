using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [SerializeField] private Player_StateMachine player_StateMachine;
    [SerializeField] private Animator animator;

    void Start()
    {
        
    }

    void Update()
    {
        if(animator.GetFloat("movement") > 0.01f)
        {
            player_StateMachine.SwitchState(player_StateMachine.player_WalkState);
        }

        if (animator.GetFloat("movement") <= 0.01f)
        {
            player_StateMachine.SwitchState(player_StateMachine.player_IdleState);
        }

    }

}
