using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Animator animator;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed = 720f;    // Degrees per second

    private Vector3 playerVelocity;
    private float gravityValue = -9.71f;

    void Start()
    {
        
    }

    void Update()
    {
        // Horizontal Input
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        move = Vector3.ClampMagnitude(move, 1f); // Prevents faster diagonal movement

        if (move != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotationSpeed * Time.deltaTime
            );

            // Walk animation
            animator.SetFloat("movement", 1);
        }

        else
        {
            animator.SetFloat("movement", 0);   // Idle animation
        }

        // Apply gravity
        playerVelocity.y += gravityValue * Time.deltaTime;

        Vector3 finalMove = (move * moveSpeed) + (playerVelocity.y * Vector3.up);

        characterController.Move(finalMove * Time.deltaTime);
        
    }
}
