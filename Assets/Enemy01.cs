using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01 : MonoBehaviour
{
    //variaveiis
    public float speed;
    public float moveTime;


    //boll, verifica a direção
    private bool isRight;
    //vai receber o deltaTime
    private float timer;

    //getComponents
    SpriteRenderer sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isRight)
        {
            sprite.flipX = false;
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            sprite.flipX = true;
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;
        if (timer >= moveTime)
        {
            isRight = !isRight;
            timer = 0f;
        }

    }



}
