using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]

public class CharacterController2D : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    [SerializeField] float speed = 2f;
    Vector2 motionVector;

    
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        motionVector = new Vector2(
            Keyboard.current.leftArrowKey.isPressed ? -1 : Keyboard.current.rightArrowKey.isPressed ? 1 : 0,
            Keyboard.current.downArrowKey.isPressed ? -1 : Keyboard.current.upArrowKey.isPressed ? 1 : 0
        );
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
