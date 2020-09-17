using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //getComponents
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sprite;
    //variaveis
    public float speed;
    public float forceJump;
    //isJumping
    private bool isJumping = false;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
   

    // Update is called once per frame
    void Update()
    {
        //variavel internta de movimento +1/-1 eixo_X
        float move = Input.GetAxis("Horizontal");

        //rigidbody
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        //jump
        Jump();

        //walk animation
        //direita+
        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("walk", true);
            sprite.flipX = false;
        }
        //esquerda-
        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("walk", true);
            sprite.flipX = true;
        }
        //idle==0
        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("walk", false);
        }

        

    }



    //jump
    void Jump()
    {
        if (Input.GetKeyDown("w") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, forceJump), ForceMode2D.Impulse);

            anim.SetBool("jump", true);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            isJumping = false;
            anim.SetBool("jump", false);
            anim.SetBool("walk", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 8)
        {
            isJumping = true;
        }

    }
}
