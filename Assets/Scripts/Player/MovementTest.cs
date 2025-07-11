using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    [SerializeField] Rigidbody rb;
    [SerializeField] Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        rb.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        moveDirection.y = 0f;

        rb.velocity = moveDirection.normalized * moveSpeed + new Vector3(0, rb.velocity.y, 0);

        //rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);

        if(horizontalInput != 0 || verticalInput != 0)
        {
            animator.SetFloat("movement", 1);
        }
    }
}
