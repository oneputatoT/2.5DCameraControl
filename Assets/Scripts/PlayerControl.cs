using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rd;
    Animator anim;
    public float speed;
    float x;
    float y;
    float preX;
    float preY;


    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 Input = (transform.right * x + transform.up * y).normalized;
        rd.velocity = Input * speed;

        if (Input != Vector2.zero)
        {
            anim.SetBool("IsWalk", true);
            preX = x;
            preY = y;
        }
        else
        {
            anim.SetBool("IsWalk", false);
        }
        anim.SetFloat("IsHorizontal", preX);
        anim.SetFloat("IsVertical", preY);
    }


}
