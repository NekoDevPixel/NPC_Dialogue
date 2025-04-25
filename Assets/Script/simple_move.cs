using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class simple_move : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    public float speed = 5f;
    Vector2 move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        
        rb.linearVelocity = new Vector2(move.x * speed, rb.linearVelocity.y);
        leftandright();
        Walkmove();
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();

    }

    public void Walkmove(){
        if(move != Vector2.zero)
        {
            animator.SetFloat("walk", Math.Abs(move.x));
        }
        else
        {
            animator.SetFloat("walk", 0);
        }
    }

    public void leftandright(){
        if(move.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(move.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
