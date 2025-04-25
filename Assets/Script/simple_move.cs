using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class simple_move : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    public float speed = 5f;
    Vector2 move;
    public GameObject conversationUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (conversationUI.activeSelf)
        {
            return; // 대화 UI가 보이면 조작을 막음
        }
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
