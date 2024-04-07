using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

[RequireComponent(typeof(Rigidbody2D))]

public class CharacterController2D : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    [SerializeField] float speed = 2f;
    Vector2 motionVector;
    public Vector2 lastMotionVector;
    Animator animator;
    public bool moving;

    void Awake()    
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");

        motionVector = new Vector2(
            Horizontal,
            Vertical
            );
        animator.SetFloat("Horizontal", Horizontal);
        animator.SetFloat("Vertical", Vertical);

        moving = Horizontal != 0 || Vertical != 0;
        animator.SetBool("Moving", moving);

        if (Horizontal !=0 || Vertical != 0)
        {
            lastMotionVector = new Vector2(
                Horizontal,
                Vertical
                ).normalized;

            animator.SetFloat("LastHorizontal", Horizontal);
            animator.SetFloat("LastVertical", Vertical);
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rigidbody2d.velocity = motionVector * speed;
    }
}
